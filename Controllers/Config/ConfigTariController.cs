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
    public class ConfigTariController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public ConfigTariController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }
        public object Get()
        {
            var result = appUnitOfWork.configTariRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.configTariRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var configTari = new ConfigTari();
            JsonConvert.PopulateObject(values, configTari);

            if (!TryValidateModel(configTari))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.configTariRepo.Add(configTari);
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
            var configTara = appUnitOfWork.configTariRepo.GetById(id);
            JsonConvert.PopulateObject(values, configTara);

            configTara.ModDate = DateTime.Now;

            if (!TryValidateModel(configTara))
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
            var tara = appUnitOfWork.configTariRepo.GetById(id);

            if (tara == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.configTariRepo.Delete(tara);
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
