using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Vistas;

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
            var model = _servicio.GetUltimosPorFecha(DateTime.Now).Result;
            return View(model);
        }
        public ActionResult GetUltimos()
        {
            var model = _servicio.GetUltimos().Result;
            return View(model);
        }
        public ActionResult GetMasClicks()
        {
            var model = _servicio.GetMasClicks().Result;
            return View(model);
        }
        public ActionResult Detalle(int id)
        {
            var model = _servicio.GetDetalle(id).Result;
            return View(model); 
        }
    }
}
