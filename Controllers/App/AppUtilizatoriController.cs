using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDisertatie.Controllers
{
    public class AppUtilizatoriController : Controller
    {
        // GET: AppUtilizatoriController
        public ActionResult Index()
        {
            return View();
        }

        // GET: AppUtilizatoriController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AppUtilizatoriController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AppUtilizatoriController/Create
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

        // GET: AppUtilizatoriController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AppUtilizatoriController/Edit/5
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

        // GET: AppUtilizatoriController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AppUtilizatoriController/Delete/5
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
