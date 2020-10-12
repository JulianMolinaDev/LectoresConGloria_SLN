using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class FormatosLibrosController : Controller
    {
        private readonly SVC_FormatoLibro _servicio;
        public FormatosLibrosController()
        {
            _servicio = new SVC_FormatoLibro();
        }
        // GET: FormatosLibros
        public ActionResult Index()
        {
            var modelo = _servicio.Get();
            return View(modelo);
        }

        // GET: FormatosLibros/Details/5
        public ActionResult Details(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // GET: FormatosLibros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FormatosLibros/Create
        [HttpPost]
        public ActionResult Create(MDL_FormatoLibro reg)
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

        // GET: FormatosLibros/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: FormatosLibros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MDL_FormatoLibro reg)
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

        // GET: FormatosLibros/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: FormatosLibros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MDL_FormatoLibro reg)
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
