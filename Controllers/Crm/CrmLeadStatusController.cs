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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public object Delete(int id, IFormCollection collection)
        {
            return Ok("Delete");
        }
    }
}
