using LectoresConGloria_SVC.Servicios;
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
        [ChildActionOnly]
        public ActionResult TextosPorLibro(int id)
        {
            var model = _servicio.GetTextosPorLibro(id);
            return PartialView(model);
        }
    }
}
