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
    public class ConfigMotiveController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public ConfigMotiveController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.configMotiveRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.configMotiveRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var configMotiv = new ConfigMotive();
            JsonConvert.PopulateObject(values, configMotiv);

            if (!TryValidateModel(configMotiv))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.configMotiveRepo.Add(configMotiv);
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
            var configMotiv = appUnitOfWork.configMotiveRepo.GetById(id);
            JsonConvert.PopulateObject(values, configMotiv);

            configMotiv.ModDate = DateTime.Now;

            if (!TryValidateModel(configMotiv))
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
            var motiv = appUnitOfWork.configMotiveRepo.GetById(id);

            if (motiv == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.configMotiveRepo.Delete(motiv);
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
