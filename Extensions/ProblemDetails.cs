using Hellang.Middleware.ProblemDetails;
using System.Security.Authentication;

namespace LoanworksBackend.Extensions;

public class ProblemDetails
{
    public static void ConfigureProblemDetails(ProblemDetailsOptions options, IWebHostEnvironment environment)
    {
        // Only include exception details in a development environment. There's really no nee
        // to set this as it's the default behavior. It's just included here for completeness :)
        options.IncludeExceptionDetails = (ctx, ex) => environment.IsDevelopment();

        // Custom mapping function for FluentValidation's ValidationException.
        //options.MapFluentValidationException();

        // You can configure the middleware to re-throw certain types of exceptions, all exceptions or based on a predicate.
        // This is useful if you have upstream middleware that needs to do additional handling of exceptions.
        options.Rethrow<NotSupportedException>();

        options.MapToStatusCode<NotImplementedException>(StatusCodes.Status501NotImplemented);
        options.MapToStatusCode<HttpRequestException>(StatusCodes.Status503ServiceUnavailable);
        options.MapToStatusCode<AuthenticationException>(StatusCodes.Status401Unauthorized);

        options.MapToStatusCode<Exception>(StatusCodes.Status500InternalServerError);
    }
}
