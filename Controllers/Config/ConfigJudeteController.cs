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
    public class ConfigJudeteController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;
        public ConfigJudeteController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.configJudeteRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.configJudeteRepo.GetAllDropDown();
            return Json(result);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var configJudet = new ConfigJudete();
            JsonConvert.PopulateObject(values, configJudet);

            if (!TryValidateModel(configJudet))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.configJudeteRepo.Add(configJudet);
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
            var configJudet = appUnitOfWork.configJudeteRepo.GetById(id);
            JsonConvert.PopulateObject(values, configJudet);

            configJudet.ModDate = DateTime.Now;

            if (!TryValidateModel(configJudet))
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
            var judet = appUnitOfWork.configJudeteRepo.GetById(id);

            if (judet == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.configJudeteRepo.Delete(judet);
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
