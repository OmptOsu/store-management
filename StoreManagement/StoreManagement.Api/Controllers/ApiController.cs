﻿using ErrorOr;
using Microsoft.AspNetCore.Mvc;
using StoreManagement.Api.Common.Http;

namespace StoreManagement.Api.Controllers;

[ApiController]
public class ApiController : ControllerBase
{
    protected IActionResult Problem(List<Error> errors)
    {

        HttpContext.Items[HttpContextItemKeys.Errors] = errors;

        var firstError = errors.FirstOrDefault();
        var statusCode = firstError.Type switch
        {
            ErrorType.Validation => StatusCodes.Status400BadRequest,
            ErrorType.Conflict => StatusCodes.Status409Conflict,
            ErrorType.NotFound => StatusCodes.Status404NotFound,
            ErrorType.Unauthorized => StatusCodes.Status401Unauthorized,
            ErrorType.Forbidden => StatusCodes.Status403Forbidden,
            _ => StatusCodes.Status500InternalServerError
        }; 
        return Problem(statusCode: statusCode, title: firstError.Description);
    }
}
