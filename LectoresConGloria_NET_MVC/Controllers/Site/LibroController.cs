using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class LibroController : Controller
    {
        public ActionResult Index(int idLibro)
        {
            return View();
        }
    }
}
