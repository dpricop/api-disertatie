using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class ConfigJudeteController : Controller
    {
        // GET: ConfigJudeteController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ConfigJudeteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ConfigJudeteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ConfigJudeteController/Create
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

        // GET: ConfigJudeteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ConfigJudeteController/Edit/5
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

        // GET: ConfigJudeteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ConfigJudeteController/Delete/5
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
