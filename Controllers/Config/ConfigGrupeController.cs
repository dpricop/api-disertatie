using ApiDisertatie.DataLayer;
using ApiDisertatie.DataLayer.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class ConfigGrupeController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public ConfigGrupeController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }
        // GET: ConfigGrupeController/Details/5
        public object Get()
        {
            return Ok("GET");
        }

        public object DropDown()
        {
            var result = appUnitOfWork.configGrupeRepo.GetAllDropDown();
            return Json(result);
        }

        [ValidateAntiForgeryToken]
        public object Create(IFormCollection collection)
        {
            return Ok("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Edit(int id, IFormCollection collection)
        {
            return Ok("Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Delete(int id, IFormCollection collection)
        {
            return Ok("Delete");
        }
    }
}
