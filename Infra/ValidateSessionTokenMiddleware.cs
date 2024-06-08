using LoanworksBackend.Core;
using LoanworksBackend.Dal;
using RepoDb;
using System.Security.Authentication;

namespace LoanworksBackend.Infra;


public class ValidateSessionTokenMiddleware
{
    private readonly RequestDelegate _next;

    public ValidateSessionTokenMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IDbContext dbContext)
    {
        string token = string.Empty;

        if (context.Request.Headers.TryGetValue("APITOKEN", out var key))
        {
            token = key.First();
        }
        else
        {
            if (context.Request.Cookies.TryGetValue("APITOKEN", out var cookie))
                token = cookie!;
        }

        if (string.IsNullOrEmpty(token))
            throw new AuthenticationException("Api token not provided");

        var sessionRecord = dbContext.Connection.ExecuteQuery<UserSession>($"EXEC SP_UserSessionValidateApi @Token"
            , new { Token = token }).FirstOrDefault();

        if(sessionRecord == null)
            throw new AuthenticationException("Session Expired");

        await _next(context);
    }
}

public static class ValidateSessionTokenMiddlewareExtensions
{
    public static IApplicationBuilder UseValidateSessionToken(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ValidateSessionTokenMiddleware>();
    }
}
