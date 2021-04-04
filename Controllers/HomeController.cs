using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{

    public class HomeController : ControllerBase
    {

        public IActionResult Index()
        {

            return Ok("200 result");
        }
    }
}
