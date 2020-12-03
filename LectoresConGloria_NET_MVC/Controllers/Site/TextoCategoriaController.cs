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
        public ActionResult CategoriaPorTexto(int id)
        {
            var modelo = _servicio.GetCategoriaPorTexto(id);
            return PartialView(modelo);
        }
        [ChildActionOnly]
        public ActionResult TextoPorCategoria(int id)
        {
            var modelo = _servicio.GetTextoPorCategoria(id);
            return PartialView(modelo);
        }
        
        public ActionResult TextosPorCategoria(int id)
        {
            var modelo = _servicio.GetTextoPorCategoria(id);
            return PartialView(modelo);
        }
    }
}