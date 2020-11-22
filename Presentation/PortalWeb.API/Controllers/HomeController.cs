using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalWeb.API.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("Test")]
        public IActionResult Index()
        {
            return Ok("Swagger testi içindir.");
        }
    }
}
