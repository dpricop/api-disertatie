using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class CrmLeadController : Controller
    {
        // GET: CrmLeadController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CrmLeadController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CrmLeadController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CrmLeadController/Create
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

        // GET: CrmLeadController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CrmLeadController/Edit/5
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

        // GET: CrmLeadController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CrmLeadController/Delete/5
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
