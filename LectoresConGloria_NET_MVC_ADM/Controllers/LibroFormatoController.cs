using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC_ADM.Controllers
{
    public class LibroFormatoController : Controller
    {
        private readonly SVC_FormatoLibro _servicio;
        public LibroFormatoController()
        {
            _servicio = new SVC_FormatoLibro();
        }
        [HttpGet]
        public ActionResult LibrosPorFormato(int id)
        {
            var modelo = _servicio.GetLibrosByFormato(id);
            return PartialView(modelo);
        }
        
        public ActionResult Delete(int id)
        {
            var modelo = _servicio.GetAsociacionDetalle(id);
            return View(modelo);
        }

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
    }
}