using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class CrmListaNotiteController : Controller
    {
        // GET: CrmListaNotiteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CrmListaNotiteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CrmListaNotiteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CrmListaNotiteController/Create
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

        // GET: CrmListaNotiteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CrmListaNotiteController/Edit/5
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

        // GET: CrmListaNotiteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CrmListaNotiteController/Delete/5
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
