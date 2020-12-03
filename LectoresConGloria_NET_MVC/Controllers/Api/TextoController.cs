using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Interfaces;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace LectoresConGloria_MVC.Controllers.Api
{

    public class TextoController : ApiController
    {
        private readonly ISVC_Texto _servicio;
        public TextoController(ISVC_Texto servicio)
        {
            _servicio = servicio;
        }
        public IEnumerable<V_Lista> GetUltimosPorFecha(DateTime fecha)
        {
            var model = _servicio.GetListaUltimosPorFecha(fecha);
            return model;
        }
        public IEnumerable<V_Lista> GetUltimos()
        {
            var model = _servicio.GetListaUltimos();
            return model;
        }
        public IEnumerable<V_Lista> GetMasClicks()
        {
            var model = _servicio.GetListaMasClicks();
            return model;
        }
        public IEnumerable<V_Lista> Detalle(int id)
        {
            var model = _servicio.GetListaMasClicks();
            return model;
        }
    }
}
