using ApiDisertatie.DataLayer;
using ApiDisertatie.DataLayer.Models;
using ApiDisertatie.DataLayer.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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
            var result = appUnitOfWork.configGrupeRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.configGrupeRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var configGrupa = new ConfigGrupe();
            JsonConvert.PopulateObject(values, configGrupa);

            if (!TryValidateModel(configGrupa))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.configGrupeRepo.Add(configGrupa);
                appUnitOfWork.SaveChanges();
                return Json(new { status = 1, count = 1 });
            }
            catch (Exception ex)
            {
                //TODO - nlog.e.Message!
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public object Edit(int id, string values)
        {
            var configGrupa = appUnitOfWork.configGrupeRepo.GetById(id);
            JsonConvert.PopulateObject(values, configGrupa);

            configGrupa.ModDate = DateTime.Now;

            if (!TryValidateModel(configGrupa))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.SaveChanges();
                return Json(new { status = 1, count = 1 });
            }
            catch (Exception ex)
            {
                //TODO - nlog e.Message !
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [ValidateAntiForgeryToken]
        public object Delete(int id)
        {
            var grupa = appUnitOfWork.configGrupeRepo.GetById(id);

            if (grupa == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.configGrupeRepo.Delete(grupa);
                appUnitOfWork.SaveChanges();

                return Json(new { status = 1, count = 1 });
            }
            catch (Exception e)
            {
                //TODO - nlog e.Message !
                return Json(new { status = 0, count = 0, message = e.Message });
            }
        }
    }
}
