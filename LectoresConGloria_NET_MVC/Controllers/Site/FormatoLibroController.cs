using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Servicios;
using System.Web.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class FormatoLibroController : Controller
    {
        SVC_FormatoLibro _servicio;
        public FormatoLibroController()
        {
            _servicio = new SVC_FormatoLibro();
        }
        [ChildActionOnly]
        public ActionResult GetFormatos(int idLibro)
        {
            var model = _servicio.GetListaByLibro(idLibro);
            return View("_GetFormatos", model);
        }
        public ActionResult GetFormatoLibro(int idFormatoLibro)
        {
            V_LibroDescarga model = _servicio.GetContenido(idFormatoLibro);
            return File(model.Contenido, model.Tipo, model.Nombre);
        }
    }
}
