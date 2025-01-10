using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace StoreManagement.Api.Controllers
{
    [Route("[controller]")]
    public class ProductController : ApiController
    {
        [HttpGet]
        public IActionResult ListProducts()
        {
            return Ok(Array.Empty<String>());
        }
    }
}
