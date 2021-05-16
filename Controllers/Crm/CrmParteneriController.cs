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
    public class CrmParteneriController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public CrmParteneriController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.crmParteneriRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.crmParteneriRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var partener = new CrmParteneri();
            JsonConvert.PopulateObject(values, partener);

            if (!TryValidateModel(partener))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.crmParteneriRepo.Add(partener);
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
            var partener = appUnitOfWork.crmParteneriRepo.GetById(id);
            //TODO CHECK if partener is null 
            JsonConvert.PopulateObject(values, partener);

            partener.ModDate = DateTime.Now;

            if (!TryValidateModel(partener))
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
            var partener = appUnitOfWork.crmParteneriRepo.GetById(id);

            if (partener == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.crmParteneriRepo.Delete(partener);
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
