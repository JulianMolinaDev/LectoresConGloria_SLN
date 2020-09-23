using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class TextoCategoriaController : Controller
    {
        // GET: TextoCategoria
        public ActionResult Index()
        {
            return View();
        }

        // GET: TextoCategoria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TextoCategoria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TextoCategoria/Create
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

        // GET: TextoCategoria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TextoCategoria/Edit/5
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

        // GET: TextoCategoria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TextoCategoria/Delete/5
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
