using LectoresConGloria_SVC.Interfaces;
using System;
using System.Web.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class TextoController : Controller
    {
        private readonly ISVC_Texto _servicio;
        public TextoController(ISVC_Texto servicio)
        {
            _servicio = servicio;
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetUltimosPorFecha()
        {
            //TODO: Revisar fecha
            var model = _servicio.GetListaUltimosPorFecha(DateTime.Now);
            return View(model);
        }
        public ActionResult GetUltimos()
        {
            var model = _servicio.GetListaUltimos();
            return View(model);
        }
        public ActionResult GetMasClicks()
        {
            var model = _servicio.GetListaMasClicks();
            return View(model);
        }
        public ActionResult Detalle(int id)
        {
            var model = _servicio.GetDetalle(id);
            return View(model); 
        }
    }
}
