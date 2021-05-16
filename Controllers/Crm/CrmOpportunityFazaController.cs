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
    public class CrmOpportunityFazaController : Controller
    {
        private readonly AppUnitOfWork appUnitOfWork;

        public CrmOpportunityFazaController(IUnitOfWork unitOfWork)
        {
            appUnitOfWork = unitOfWork as AppUnitOfWork;
        }

        public object Get()
        {
            var result = appUnitOfWork.crmOpportunityFazaRepo.GetAllTable();
            return Json(result);
        }

        public object DropDown()
        {
            var result = appUnitOfWork.crmOpportunityFazaRepo.GetAllDropDown();
            return Json(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Create(string values)
        {
            var opportunityFaza = new CrmOpportunityFaza();
            JsonConvert.PopulateObject(values, opportunityFaza);

            if (!TryValidateModel(opportunityFaza))
                return BadRequest(ModelState.IsValid);

            try
            {
                appUnitOfWork.crmOpportunityFazaRepo.Add(opportunityFaza);
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
            var opportunityFaza = appUnitOfWork.crmOpportunityFazaRepo.GetById(id);
            JsonConvert.PopulateObject(values, opportunityFaza);

            opportunityFaza.ModDate = DateTime.Now;

            if (!TryValidateModel(opportunityFaza))
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
            var opportunityFaza = appUnitOfWork.crmOpportunityFazaRepo.GetById(id);

            if (opportunityFaza == null)
                return Json(new { status = 0, count = 0 });

            try
            {
                appUnitOfWork.crmOpportunityFazaRepo.Delete(opportunityFaza);
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
