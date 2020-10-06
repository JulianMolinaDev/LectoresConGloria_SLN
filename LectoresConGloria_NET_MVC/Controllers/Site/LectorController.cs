using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using System.Web.Mvc;

namespace LectoresConGloria_MVC.Controllers.Site
{
    public class LectorController : Controller
    {
        private readonly ISVC_Lector _servicio;
        public LectorController(ISVC_Lector servicio)
        {
            _servicio = servicio;
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(MDL_Login login)
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
