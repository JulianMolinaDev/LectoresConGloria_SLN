using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class FormatosLibrosController : Controller
    {
        // GET: FormatosLibros
        public ActionResult Index()
        {
            return View();
        }

        // GET: FormatosLibros/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FormatosLibros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormatosLibros/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FormatosLibros/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FormatosLibros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: FormatosLibros/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FormatosLibros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
