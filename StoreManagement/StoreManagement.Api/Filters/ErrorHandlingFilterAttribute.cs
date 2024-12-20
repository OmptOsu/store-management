using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace StoreManagement.Api.Filters;

public class ErrorHandlingFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;
        var errorResult = new { error = "An error occured while processing your request" };
        var code = HttpStatusCode.InternalServerError;

        context.Result = new ObjectResult(errorResult)
        {
            StatusCode = (int)code
        };
        context.ExceptionHandled = true;
    }
}
