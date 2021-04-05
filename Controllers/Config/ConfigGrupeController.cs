using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class ConfigGrupeController : Controller
    {
        // GET: ConfigGrupeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConfigGrupeController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfigGrupeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigGrupeController/Create
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

        // GET: ConfigGrupeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfigGrupeController/Edit/5
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

        // GET: ConfigGrupeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfigGrupeController/Delete/5
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
