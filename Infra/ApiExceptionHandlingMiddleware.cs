using LoanworksBackend.Core;
using LoanworksBackend.Core.Errors;
using LoanworksBackend.Dal;
using MediatR;
using RepoDb;
using System.Globalization;
using System.Security.Authentication;

namespace LoanworksBackend.Infra;


public class ApiExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;

    public ApiExceptionHandlingMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context, IMediator mediator)
    {
        try
        {
            await _next(context);
        }
        catch (Exception )
        {
            await mediator.Send<IResult>(new ErrorInput() { Context = context });
        }
    }
}

public static class ApiExceptionHandlingMiddlewareExtensions
{
    public static IApplicationBuilder UseApiExceptionHandling(
        this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<ApiExceptionHandlingMiddleware>();
    }
}
