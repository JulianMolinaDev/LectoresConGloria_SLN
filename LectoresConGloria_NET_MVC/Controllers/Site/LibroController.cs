using LectoresConGloria_SVC.Servicios;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using System.IO;
using LectoresConGloria_NET_MVC.Constantes;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class LibroController : Controller
    {
        readonly SVC_Libro _servicio;
        public LibroController()
        {
            _servicio = new SVC_Libro();
        }
        public ActionResult Index()
        {
            var modelo = _servicio.Get().ToList();
            modelo.ForEach(x => x.Imagen = Path.Combine(Globales.pathToFiles, "Portadas", x.Imagen));
            return View(modelo);
        }
        public ActionResult Detalle(int idLibro)
        {
            var modelo = _servicio.Get(idLibro);
            modelo.Imagen = Path.Combine(Globales.pathToFiles, "Portadas", modelo.Imagen);
            return View(modelo);
        }
    }
}
