﻿using ApiDisertatie.DataLayer;
using ApiDisertatie.DataLayer.UnitOfWork;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

        [ValidateAntiForgeryToken]
        public object Create(IFormCollection collection)
        {
            return Ok("Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Edit(int id, IFormCollection collection)
        {
            return Ok("Edit");
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
