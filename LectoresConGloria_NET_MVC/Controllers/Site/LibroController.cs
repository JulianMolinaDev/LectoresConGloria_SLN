using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class LibroController : Controller
    {
        readonly SVC_Libro _servicio;
        public LibroController()
        {
            _servicio = new SVC_Libro();
        }
        public ActionResult Index()
        {
            var modelo = _servicio.Get();
            return View(modelo);
        }
        public ActionResult Detalle(int idLibro)
        {
            var modelo = _servicio.Get(idLibro);
            return View(modelo);
        }
    }
}
