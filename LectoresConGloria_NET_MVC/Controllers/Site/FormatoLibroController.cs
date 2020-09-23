using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class FormatoLibroController : Controller
    {
        public IActionResult GetFormatos(int idLibro)
        {
            return View();
        }
    }
}
