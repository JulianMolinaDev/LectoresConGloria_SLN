using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Vistas;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class TextoController : Controller
    {
        private readonly ISVC_Texto _servicio;
        public TextoController(ISVC_Texto servicio)
        {
            _servicio = servicio;
        }
        public IActionResult Index()
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
            return Ok(model);
        }
    }
}
