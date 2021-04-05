using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class ConfigLocalitatiController : Controller
    {
        // GET: ConfigLocalitatiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConfigLocalitatiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfigLocalitatiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigLocalitatiController/Create
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

        // GET: ConfigLocalitatiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfigLocalitatiController/Edit/5
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

        // GET: ConfigLocalitatiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfigLocalitatiController/Delete/5
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
