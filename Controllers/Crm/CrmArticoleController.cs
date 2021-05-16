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
    public class CrmArticoleController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public CrmArticoleController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;

        }

        public object Get()
        {
            var result = appUnitOfWork.crmArticoleRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.crmArticoleRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var articol = new CrmArticole();
            JsonConvert.PopulateObject(values, articol);

            if (!TryValidateModel(articol))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.crmArticoleRepo.Add(articol);
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
            var articol = appUnitOfWork.crmArticoleRepo.GetById(id);
            JsonConvert.PopulateObject(values, articol);

            articol.ModDate = DateTime.Now;

            if (!TryValidateModel(articol))
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
            var articol = appUnitOfWork.crmArticoleRepo.GetById(id);

            if (articol == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.crmArticoleRepo.Delete(articol);
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
