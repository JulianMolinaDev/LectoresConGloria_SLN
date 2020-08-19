using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using Microsoft.AspNetCore.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class UsuarioController : Controller
    {
        private readonly ISVC_Usuario _servicio;
        public UsuarioController(ISVC_Usuario servicio)
        {
            _servicio = servicio;
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(MDL_Login login)
        {
            var user = _servicio.Login(login);
            if (user != null)
            {
                return RedirectToAction("Index","Home");
            }
            return View(login);
        }
    }
}
