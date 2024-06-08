using Microsoft.Data.SqlClient;
using LoanworksBackend.Extensions;
using LoanworksBackend.Dal;
using MediatR;
using Serilog;
using LoanworksBackend;
using Prometheus;
using LoanworksBackend.Infra;
using System.Reflection;
using Microsoft.AspNetCore.HttpLogging;
using Hellang.Middleware.ProblemDetails.Mvc;
using Hellang.Middleware.ProblemDetails;
using Microsoft.OpenApi.Models;

AppSettings _appSettings = new();
var builder = WebApplication.CreateBuilder(args);

//for CORS
builder.Services.AddCors(p => p.AddPolicy("corsapp", builder =>
{
    builder.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
}));

// serilog logging
builder.Host.UseSerilog((context, config) => config
    .Enrich.FromLogContext()
    .WriteTo.Console());

// config
IConfiguration configuration = builder.Configuration;
configuration.GetSection("AppSettings").Bind(_appSettings);
builder.Services.AddSingleton<AppSettings>((sp) =>
{
    return _appSettings;
});

// Add services to the container.
builder.RegisterModules();

builder.Services.AddProblemDetails((prbOptions) =>
{
    ProblemDetails.ConfigureProblemDetails(prbOptions, builder.Environment);
})
.AddControllers()
.AddProblemDetailsConventions();

builder.Services.AddMediatR(typeof(Program));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var security = new Dictionary<string, IEnumerable<string>>
    {
        {"Bearer", new string[] { }},
    };

    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "APITOKEN",
        Type = SecuritySchemeType.ApiKey
    });
    options.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "Bearer" }
            },
            new string[] { }
        }
    });

    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

if (_appSettings.LosWebservice == null)
    throw new NullReferenceException("_appSettings.LosWebservice missing from appsettings.json");

builder.Services.AddHttpClient("los-webservice", c =>
{
    c.Timeout = TimeSpan.FromSeconds(_appSettings.LosWebservice.TimeoutInSeconds);
    c.BaseAddress = new Uri(_appSettings.LosWebservice.Url);
});
builder.Services.AddHttpClient("external-doc-api", c =>
{
    c.Timeout = TimeSpan.FromSeconds(_appSettings.LosWebservice.TimeoutInSeconds);
    c.BaseAddress = new Uri("https://dowsapi.uat.resimac.com.au/");
    //c.BaseAddress = new Uri("http://localhost:3001");
});

if (_appSettings.ConnectionStrings == null)
    throw new NullReferenceException("_appSettings.ConnectionStrings missing from appsettings.json");

builder.Services.AddHealthChecks()
    .AddSqlServer(_appSettings.ConnectionStrings.LosDb, "SELECT 1", "LOS Database");

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.RequestProperties | HttpLoggingFields.ResponseStatusCode;
    logging.MediaTypeOptions.AddText("application/json");
});

builder.Host.ConfigureServices(services =>
{
    services.AddScoped<IDbContext>((provider) => new LosDbContext(new SqlConnection(_appSettings.ConnectionStrings.LosDb)));
});
//var devCorsPolicy = "devCorsPolicy";
//builder.Services.AddCors(options =>
//{
//    options.AddPolicy(devCorsPolicy, builder => {
//        builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
//    });
//});

var app = builder.Build();
//app.UseCors(devCorsPolicy);
app.MapEndpoints();

RepoDb.SqlServerBootstrap.Initialize();

//cors
app.UseCors("corsapp");
app.UseSwagger();
app.UseSwaggerUI();

app.UseProblemDetails();

//app.UseAuthorization();
app.UseHttpLogging();

// turn on LOS security
//app.UseValidateSessionToken();

if (_appSettings.EnableHealthChecks)
    app.MapHealthChecks("/health");

app.UseMetricServer();
app.UseHttpMetrics();

app.Run();