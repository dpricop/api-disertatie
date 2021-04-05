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
        // GET: CrmOpportunityFazaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CrmOpportunityFazaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CrmOpportunityFazaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CrmOpportunityFazaController/Create
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

        // GET: CrmOpportunityFazaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CrmOpportunityFazaController/Edit/5
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

        // GET: CrmOpportunityFazaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CrmOpportunityFazaController/Delete/5
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
