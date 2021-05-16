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
    public class ConfigLocalitatiController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;
        public ConfigLocalitatiController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.configLocalitatiRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.configLocalitatiRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var configLocalite = new ConfigLocalitati();
            JsonConvert.PopulateObject(values, configLocalite);

            if (!TryValidateModel(configLocalite))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.configLocalitatiRepo.Add(configLocalite);
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
            var configLocalitate = appUnitOfWork.configLocalitatiRepo.GetById(id);
            JsonConvert.PopulateObject(values, configLocalitate);

            configLocalitate.ModDate = DateTime.Now;

            if (!TryValidateModel(configLocalitate))
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
            var localitate = appUnitOfWork.configLocalitatiRepo.GetById(id);

            if (localitate == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.configLocalitatiRepo.Delete(localitate);
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
