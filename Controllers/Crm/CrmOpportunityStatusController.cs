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
    public class CrmOpportunityStatusController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public CrmOpportunityStatusController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.crmOpportunityStatusRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.crmOpportunityStatusRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var opportunityStatus = new CrmOpportunityStatus();
            JsonConvert.PopulateObject(values, opportunityStatus);

            if (!TryValidateModel(opportunityStatus))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.crmOpportunityStatusRepo.Add(opportunityStatus);
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
            var opportunityStatus = appUnitOfWork.crmOpportunityStatusRepo.GetById(id);
            JsonConvert.PopulateObject(values, opportunityStatus);

            opportunityStatus.ModDate = DateTime.Now;

            if (!TryValidateModel(opportunityStatus))
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
            var opportunityStatus = appUnitOfWork.crmOpportunityStatusRepo.GetById(id);

            if (opportunityStatus == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.crmOpportunityStatusRepo.Delete(opportunityStatus);
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
