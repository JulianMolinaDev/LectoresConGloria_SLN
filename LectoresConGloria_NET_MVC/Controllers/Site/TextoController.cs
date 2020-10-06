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
        public ActionResult GetUltimosPorFecha(DateTime fecha)
        {
            return View();
        }
        public ActionResult GetUltimos()
        {
            return View();
        }
        public ActionResult GetMasClicks()
        {
            return View();
        }
        public ActionResult Detalle(int id)
        {
            var model = _servicio.GetDetalle(id).Result;
            return View(); 
        }
    }
}
