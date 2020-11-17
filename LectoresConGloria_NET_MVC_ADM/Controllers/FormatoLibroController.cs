using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_NET_MVC_ADM.Models;
using LectoresConGloria_NET_MVC_ADM.Utilidades;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class FormatoLibroController : Controller
    {
        private readonly SVC_FormatoLibro _servicio;
        public FormatoLibroController()
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
        public ActionResult AsignarFormato(int id)
        {
            ViewBag.Formatos = _servicio.FaltantesFormatosByLibro(id);
            var modelo = new VM_FormatoLibro()
            {
                IdLibro = id,
                Archivo = null,
            };
            return View(modelo);
        }

        // POST: FormatosLibros/Create
        [HttpPost]
        public ActionResult AsignarFormato(VM_FormatoLibro reg)
        {
            try
            {
                _servicio.Post(new MDL_FormatoLibro()
                {
                    Contenido = reg.Archivo.InputStream.StreamToByteArray(),
                    IdFormato = reg.IdFormato,
                    IdLibro = reg.IdLibro
                });
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

        public ActionResult FormatosPorLibro(int id)
        {
            var modelo = _servicio.GetFormatosByLibro(id);
            return View(modelo);
        }
        public ActionResult LibrosPorFormato(int id)
        {
            var modelo = _servicio.GetLibrosByFormato(id);
            return PartialView(modelo);
        }
        [HttpGet]
        public ActionResult CambiarFormato(int id)
        {
            var modelo = _servicio.GetLibroAsItem(id);
            return PartialView(modelo);
        }
    }
}
