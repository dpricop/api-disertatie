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
        // GET: CrmLeadStatusController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CrmLeadStatusController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CrmLeadStatusController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CrmLeadStatusController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CrmLeadStatusController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CrmLeadStatusController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CrmLeadStatusController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CrmLeadStatusController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
