using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC_ADM.Controllers
{
    public class TextoController : Controller
    {
        // GET: TextoController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TextoController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TextoController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TextoController/Create
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

        // GET: TextoController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TextoController/Edit/5
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

        // GET: TextoController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TextoController/Delete/5
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
