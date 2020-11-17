using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System.Web.Http;

namespace LectoresConGloria_MVC.Controllers.Api
{
    public class UsuarioController : ApiController
    {
        private readonly ISVC_Usuario _servicio;
        public UsuarioController()
        {
            _servicio = new SVC_Usuario();
        }

        public MDL_Usuario Login(MDL_Login login)
        {
            var usuario = _servicio.Login(login);
            return usuario;
        }
        public void Register(MDL_Usuario reg)
        {
            _servicio.Register(reg);
        }
    }
}
