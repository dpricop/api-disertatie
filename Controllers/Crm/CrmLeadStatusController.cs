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
    public class CrmLeadStatusController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public CrmLeadStatusController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;

        }

        public object Get()
        {
            var result = appUnitOfWork.crmLeadStatusRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.crmLeadStatusRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var leadStatus = new CrmLeadStatus();
            JsonConvert.PopulateObject(values, leadStatus);

            if (!TryValidateModel(leadStatus))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.crmLeadStatusRepo.Add(leadStatus);
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
            var leadStatus = appUnitOfWork.crmLeadStatusRepo.GetById(id);
            JsonConvert.PopulateObject(values, leadStatus);

            leadStatus.ModDate = DateTime.Now;

            if (!TryValidateModel(leadStatus))
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
            var leadStatus = appUnitOfWork.crmLeadStatusRepo.GetById(id);

            if (leadStatus == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.crmLeadStatusRepo.Delete(leadStatus);
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
