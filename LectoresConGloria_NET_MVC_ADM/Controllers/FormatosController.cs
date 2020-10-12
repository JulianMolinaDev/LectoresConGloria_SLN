using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class FormatosController : Controller
    {
        private readonly SVC_Formato _servicio;
        public FormatosController()
        {
            _servicio = new SVC_Formato();
        }
        // GET: Formatos
        public ActionResult Index()
        {
            var model = _servicio.Get();
            return View(model);
        }

        // GET: Formatos/Details/5
        public ActionResult Details(int id)
        {
            var model = _servicio.Get(id);
            return View(model);
        }

        // GET: Formatos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Formatos/Create
        [HttpPost]
        public ActionResult Create(MDL_Formato reg)
        {
            try
            {
                _servicio.Post(reg);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(reg);
            }
        }

        // GET: Formatos/Edit/5
        public ActionResult Edit(int id)
        {
            var model = _servicio.Get(id);
            return View(model);
        }

        // POST: Formatos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MDL_Formato reg)
        {
            try
            {
                _servicio.Put(id, reg);

                return RedirectToAction("Index");
            }
            catch
            {
                return View(reg);
            }
        }

        // GET: Formatos/Delete/5
        public ActionResult Delete(int id)
        {
            var model = _servicio.Get(id);
            return View(model);
        }

        // POST: Formatos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MDL_Formato reg)
        {
            try
            {
                _servicio.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View(reg);
            }
        }
    }
}
