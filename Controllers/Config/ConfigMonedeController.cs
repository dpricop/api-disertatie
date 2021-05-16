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
    public class ConfigMonedeController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public ConfigMonedeController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }
        public object Get()
        {
            var result = appUnitOfWork.configMonedeRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.configMonedeRepo.GetAllDropDown();
            return Json(result);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var configMoneda = new ConfigMonede();
            JsonConvert.PopulateObject(values, configMoneda);

            if (!TryValidateModel(configMoneda))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.configMonedeRepo.Add(configMoneda);
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
            var configMoneda = appUnitOfWork.configMonedeRepo.GetById(id);
            JsonConvert.PopulateObject(values, configMoneda);

            configMoneda.ModDate = DateTime.Now;

            if (!TryValidateModel(configMoneda))
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
            var moneda = appUnitOfWork.configMonedeRepo.GetById(id);

            if (moneda == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.configMonedeRepo.Delete(moneda);
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
