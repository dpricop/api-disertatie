using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class ConfigMonedeController : Controller
    {
        // GET: ConfigMonedeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConfigMonedeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfigMonedeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigMonedeController/Create
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

        // GET: ConfigMonedeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfigMonedeController/Edit/5
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

        // GET: ConfigMonedeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfigMonedeController/Delete/5
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
