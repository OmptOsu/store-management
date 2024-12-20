using Microsoft.AspNetCore.Mvc;

namespace StoreManagement.Api.Controllers;

[ApiExplorerSettings(IgnoreApi = true)]//<--- Needed for swagger to work with routing error handling
public class ErrorsController: ControllerBase
{
    [Route("/error")]
    public IActionResult Error() => Problem();
}
