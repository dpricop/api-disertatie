using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class CrmPartenerContacteController : Controller
    {
        // GET: CrmPartenerContacteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CrmPartenerContacteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CrmPartenerContacteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CrmPartenerContacteController/Create
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

        // GET: CrmPartenerContacteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CrmPartenerContacteController/Edit/5
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

        // GET: CrmPartenerContacteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CrmPartenerContacteController/Delete/5
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
