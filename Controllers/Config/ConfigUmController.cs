using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class ConfigUmController : Controller
    {
        // GET: ConfigUmController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConfigUmController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfigUmController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigUmController/Create
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

        // GET: ConfigUmController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfigUmController/Edit/5
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

        // GET: ConfigUmController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfigUmController/Delete/5
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
