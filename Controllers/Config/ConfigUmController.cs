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
    public class ConfigUmController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public ConfigUmController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.configUmRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.configUmRepo.GetAllDropDown();
            return Json(result);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var configUm = new ConfigUm();
            JsonConvert.PopulateObject(values, configUm);

            if (!TryValidateModel(configUm))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.configUmRepo.Add(configUm);
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
            var configUm = appUnitOfWork.configUmRepo.GetById(id);
            JsonConvert.PopulateObject(values, configUm);

            configUm.ModDate = DateTime.Now;

            if (!TryValidateModel(configUm))
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
            var um = appUnitOfWork.configUmRepo.GetById(id);

            if (um == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.configUmRepo.Delete(um);
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
