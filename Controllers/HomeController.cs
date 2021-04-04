using ApiDisertatie.DataLayer;
using ApiDisertatie.DataLayer.Models;
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
        private readonly DatabaseContext dataContext;

        public HomeController(DatabaseContext appContext)
        {
            dataContext = appContext as DatabaseContext;
        }

        public IActionResult Index()
        {
           

            return Ok("200 result");
        }

        public IActionResult Test()
        {
            var result = dataContext.ConfigTari.Select(s => new {s.IdTara, s.NumeTara, s.CodTara}).ToList();
            //return Ok(new { success = true, data = result});
            return Ok(result);
        }
    }

}
