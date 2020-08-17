using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectoresConGloria_MDL.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class UsuarioController : Controller
    {
        public UsuarioController()
        {

        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(MDL_Login login)
        {
            return View();
        }
    }
}
