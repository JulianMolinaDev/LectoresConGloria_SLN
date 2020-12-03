using LectoresConGloria_SVC.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System.Web.Http;

namespace LectoresConGloria_MVC.Controllers.Api
{
    public class ClickController : ApiController
    {
        private readonly ISVC_Click _servicio;
        public ClickController()
        {
            _servicio = new SVC_Click();
        }
        public void Write([FromBody] MDL_Click click)
        {
            _servicio.Write(click);
        }
    }
}
