using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class UsuarioController : Controller
    {
        public UsuarioController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
