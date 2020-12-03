using LectoresConGloria_MDL.Enumerados;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Web.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class ClickController : Controller
    {
        private readonly SVC_Click _servicio;
        public ClickController()
        {
            _servicio = new SVC_Click();
        }
        public ActionResult Add(int idTexto, string tipo)
        {
            var click = new MDL_Click()
            {
                FechaAlta = DateTime.Now,
                IdTexto = idTexto,
                IdUsuario = ((MDL_Usuario)Session["Usuario"]).Id
            };
            switch (tipo)
            {
                case "EXPLICACION":
                    click.TipoClick = (int)TipoClick.EXPLICACION;
                    break;
                case "AUDIO":
                    click.TipoClick = (int)TipoClick.AUDIO;
                    break;
                case "TEXTO":
                    click.TipoClick = (int)TipoClick.TEXTO;
                    break;
                default:
                    click.TipoClick = (int)TipoClick.TEXTO;
                    break;
            }
            _servicio.Write(click);
            return Json(new { result = "Ok" });
        }
    }
}
