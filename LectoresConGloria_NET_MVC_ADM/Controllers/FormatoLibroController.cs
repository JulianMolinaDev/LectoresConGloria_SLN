using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_NET_MVC_ADM.Models;
using LectoresConGloria_NET_MVC_ADM.Utilidades;
using LectoresConGloria_SVC.Servicios;
using System;
using System.IO;
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
            var modelo = new MDL_FormatoLibro()
            {
                IdLibro = id
            };
            return View(modelo);
        }

        // POST: FormatosLibros/Create
        [HttpPost]
        public ActionResult AsignarFormato(MDL_FormatoLibro reg)
        {
            try
            {
                _servicio.Post(reg);
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Formatos = _servicio.FaltantesFormatosByLibro(reg.IdLibro);
                return View(reg);
            }
        }

        // GET: FormatosLibros/Delete/5
        public ActionResult Delete(int id)
        {
            var modelo = _servicio.GetAsociacionDetalle(id);
            return View(modelo);
        }

        // POST: FormatosLibros/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, V_AsociacionDetalle reg)
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
        [HttpGet]
        public ActionResult FormatosPorLibro(int id)
        {
            var modelo = _servicio.GetFormatosByLibro(id);
            return PartialView(modelo);
        }

    }
}
