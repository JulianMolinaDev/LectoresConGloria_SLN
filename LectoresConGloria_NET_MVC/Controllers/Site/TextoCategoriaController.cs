using LectoresConGloria_SVC.Servicios;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC.Controllers.Site
{
    public class TextoCategoriaController : Controller
    {
        readonly SVC_TextoCategoria _servicio;
        public TextoCategoriaController()
        {
            _servicio = new SVC_TextoCategoria();
        }
        [ChildActionOnly]
        public ActionResult CategoriaPorTexto(int idTexto)
        {
            var modelo = _servicio.GetCategoriaPorTexto(idTexto);
            return View(modelo);
        }
        [ChildActionOnly]
        public ActionResult TextoPorCategoria(int idCategoria)
        {
            var modelo = _servicio.GetTextoPorCategoria(idCategoria);
            return View(modelo);
        }
    }
}