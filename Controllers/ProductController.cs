using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FiltersExample.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FiltersExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthorizationFilter]
    [ResourceFilter]
    [ActionFilter]
    [ExceptionFilter]
    [ResultFilter]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string GetProduct()
        {
            return "This is product list page";
        }

    }
}
