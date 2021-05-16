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
    public class CrmPartenerContacteController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public CrmPartenerContacteController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.crmPartenerContacteRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.crmPartenerContacteRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var partenerContact = new CrmPartenerContacte();
            JsonConvert.PopulateObject(values, partenerContact);

            if (!TryValidateModel(partenerContact))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.crmPartenerContacteRepo.Add(partenerContact);
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
            var partenerContact = appUnitOfWork.crmPartenerContacteRepo.GetById(id);
            //TODO CHECK if partenerContact is null 
            JsonConvert.PopulateObject(values, partenerContact);

            partenerContact.ModDate = DateTime.Now;

            if (!TryValidateModel(partenerContact))
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
            var partenerContact = appUnitOfWork.crmPartenerContacteRepo.GetById(id);

            if (partenerContact == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.crmPartenerContacteRepo.Delete(partenerContact);
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
