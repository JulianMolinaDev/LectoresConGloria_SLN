using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class TextoController : Controller
    {
        // GET: Texto
        public ActionResult Index()
        {
            return View();
        }

        // GET: Texto/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Texto/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Texto/Create
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

        // GET: Texto/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Texto/Edit/5
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

        // GET: Texto/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Texto/Delete/5
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
