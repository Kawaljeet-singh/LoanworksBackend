using MediatR;
using Microsoft.AspNetCore.Diagnostics;
using System.Net;
using System.Security.Authentication;

namespace LoanworksBackend.Core.Errors;

public class ErrorInput : IRequest<IResult>
{
    public HttpContext? Context { get; set; }
    public Exception? Exception { get; set; }
}

public class ErrorHandler : IRequestHandler<ErrorInput, IResult>
{
    public Task<IResult> Handle(ErrorInput request, CancellationToken cancellationToken)
    {
        
        return Task.FromResult(Results.BadRequest("done"));
    }

    //private (int, ApiErrorResponse) GetExceptionResponse(Exception baseException, HttpContext context)
    //{
    //    var result = new ErrorDescription()
    //    {
    //        Code = baseException.GetExceptionCode(),
    //        Message = baseException.GetExceptionMessageForDisplay(),
    //        ErrorDetails = baseException.GetErrorDetails()
    //    };

    //    HttpStatusCode statusCode;
    //    string errorType;

    //    var exceptionHandlerFeature =
    //        context.Features.Get<IExceptionHandlerFeature>()!;        

    //    var problem = Results.Problem(
    //        detail: exceptionHandlerFeature.Error.StackTrace,
    //        title: exceptionHandlerFeature.Error.Message);

    //    if (baseException is ValidationCommandException)
    //    {
    //        switch (((ValidationCommandException)baseException).ApiStatusCode)
    //        {
    //            case HttpStatusCode.InternalServerError:
    //                errorType = "UNEXPECTED_ERROR";
    //                break;
    //            case HttpStatusCode.NotFound:
    //                errorType = "NOT_FOUND_ERROR";
    //                break;
    //            default:
    //                errorType = "VALIDATION_ERROR";
    //                break;
    //        }
    //        statusCode = ((ValidationCommandException)baseException).ApiStatusCode;
    //    }
    //    else if (baseException is InvalidCredentialException || baseException is AuthenticationException)
    //    {
    //        statusCode = HttpStatusCode.Unauthorized;
    //        errorType = "AUTHORISATION_ERROR";
    //    }
    //    else if (baseException is InternalApplicationException)
    //    {
    //        statusCode = HttpStatusCode.InternalServerError;
    //        errorType = "SVRV_ERROR";
    //    }
    //    else if (baseException is ArgumentException || baseException is MissingFieldException)
    //    {
    //        statusCode = HttpStatusCode.BadRequest;
    //        errorType = "BAD_PARAM_ERROR";
    //    }
    //    else if (baseException is DuplicateException)
    //    {
    //        statusCode = HttpStatusCode.Conflict;
    //        errorType = "RES_CONFLICT";
    //    }
    //    else if (baseException is ApplicationException)
    //    {
    //        statusCode = HttpStatusCode.InternalServerError;
    //        errorType = "SVRV_ERROR";
    //    }
    //    else if (baseException is RecordNotFoundException)
    //    {
    //        statusCode = HttpStatusCode.NotFound;
    //        errorType = "NO_RECORD";
    //    }
    //    else
    //    {
    //        statusCode = HttpStatusCode.InternalServerError;
    //        errorType = "ERR_INTERNAL";
    //        result.Code = null;
    //        result.Message = null;
    //    }

    //    result.ErrorType = errorType;

    //    return ((int)statusCode, new ApiErrorResponse() { Error = result });
    //}
}
