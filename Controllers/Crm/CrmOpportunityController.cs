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
    public class CrmOpportunityController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public CrmOpportunityController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.crmOpportunityRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.crmOpportunityRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var opportunity = new CrmOpportunity();
            JsonConvert.PopulateObject(values, opportunity);

            if (!TryValidateModel(opportunity))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.crmOpportunityRepo.Add(opportunity);
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
            var opportunity = appUnitOfWork.crmOpportunityRepo.GetById(id);
            JsonConvert.PopulateObject(values, opportunity);

            opportunity.ModDate = DateTime.Now;

            if (!TryValidateModel(opportunity))
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
            var opportunity = appUnitOfWork.crmOpportunityRepo.GetById(id);

            if (opportunity == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.crmOpportunityRepo.Delete(opportunity);
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
