using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_MVC.Servicios
{
    public class SVC_MVC_Click : ISVC_Click
    {
        private readonly SVC_Click _servicio;
        public SVC_MVC_Click(SVC_Click servicio)
        {
            _servicio = servicio;
        }

        public async Task<bool> Write(MDL_Click reg)
        {
            return await _servicio.Write(reg);
        }
    }
}
