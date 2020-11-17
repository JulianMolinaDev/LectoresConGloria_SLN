using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class LibroController : Controller
    {
        readonly SVC_Libro _servicio;
        public LibroController()
        {
            _servicio = new SVC_Libro();
        }
        // GET: Libros
        public ActionResult Index()
        {
            var modelo = _servicio.Get();
            return View("Lista", modelo);
        }

        public ActionResult Busqueda(string nombre)
        {
            var modelo = _servicio.GetListByNombre(nombre);
            return View("Lista", modelo);
        }

        // GET: Libros/Details/5
        public ActionResult Details(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // GET: Libros/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Libros/Create
        [HttpPost]
        public ActionResult Create(MDL_Libro reg)
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

        // GET: Libros/Edit/5
        public ActionResult Edit(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: Libros/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, MDL_Libro reg)
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

        // GET: Libros/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = _servicio.Get(id);
            return View(modelo);
        }

        // POST: Libros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, MDL_Libro reg)
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
