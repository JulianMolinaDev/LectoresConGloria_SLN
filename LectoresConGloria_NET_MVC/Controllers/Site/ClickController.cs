using LectoresConGloria_MDL.Enumerados;
using System.Web.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class ClickController : Controller
    {
        public ClickController()
        {

        }
        public ActionResult Goto(int idTexto, int tipoClick)
        {
            var caso = (TipoClick)tipoClick;
            switch (caso)
            {
                case TipoClick.EXPLICACION:
                    return View("Explicacion");
                case TipoClick.AUDIO:
                    return View("Audio");
                case TipoClick.TEXTO:
                    return File(@"Archivos\Paro Paquito.pdf.", "application/pdf");
                default:
                    return View();
            }            
        }
    }
}
