using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class ConfigTariController : Controller
    {
        // GET: ConfigTariController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConfigTariController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfigTariController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigTariController/Create
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

        // GET: ConfigTariController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfigTariController/Edit/5
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

        // GET: ConfigTariController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfigTariController/Delete/5
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
