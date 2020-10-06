using LectoresConGloria_MDL.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_NET_MVC.Controllers
{
    public class SecurityController : Controller
    {
        // GET: Security
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(MDL_Login login)
        {
            return View();
        }
        public ActionResult Logoff()
        {
            return View();
        }
    }
}