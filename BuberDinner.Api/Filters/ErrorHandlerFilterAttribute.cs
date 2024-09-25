using System.Net;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BuberDinner.Api.Filters;

public class ErrorHandlerFilterAttribute : ExceptionFilterAttribute
{
    public override void OnException(ExceptionContext context)
    {
        var exception = context.Exception;

        var problemDetails = new ProblemDetails
        {
            Type = "http://tools.ietf.org/html/rfc7231#section-6.6.1",
            Title = "An error occured while processing your request.",
            Status = (int)HttpStatusCode.InternalServerError
        };

        context.Result = new ObjectResult(problemDetails);

        context.ExceptionHandled = true;
    }
}