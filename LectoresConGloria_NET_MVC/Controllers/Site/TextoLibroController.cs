﻿using LectoresConGloria_SVC.Servicios;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class TextoLibroController : Controller
    {
        readonly SVC_TextoLibro _servicio;
        public TextoLibroController()
        {
            _servicio = new SVC_TextoLibro();
        }
        public ActionResult TextosPorLibro(int idLibro)
        {
            var model = _servicio.GetTextosPorLibro(idLibro);
            return View(model);
        }
    }
}
