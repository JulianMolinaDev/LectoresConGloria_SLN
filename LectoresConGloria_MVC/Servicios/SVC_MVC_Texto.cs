using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_MVC.Servicios
{
    public class SVC_MVC_Texto : ISVC_Texto
    {
        private readonly SVC_Texto _servicio;
        public SVC_MVC_Texto(SVC_Texto servicio)
        {
            _servicio = servicio;
        }
        public async Task<bool> Delete(int id)
        {
            return await _servicio.Delete(id);
        }

        public async Task<MDL_Texto> Get(int id)
        {
            return await _servicio.Get(id);
        }

        public async Task<IEnumerable<MDL_Texto>> Get()
        {
            return await _servicio.Get();
        }

        public async Task<IEnumerable<V_Lista>> GetMasClicks()
        {
            return await _servicio.GetMasClicks();
        }

        public async Task<bool> Post(MDL_Texto reg)
        {
            return await _servicio.Post(reg);
        }

        public async Task<bool> Put(int id, MDL_Texto reg)
        {
            return await _servicio.Put(id, reg);
        }

        public async Task<IEnumerable<V_Lista>> GetUltimos()
        {
            return await _servicio.GetUltimos();
        }

        public async Task<IEnumerable<V_Lista>> GetUltimosPorFecha(DateTime fecha)
        {
            return await _servicio.GetUltimosPorFecha(fecha);
        }
    }
}
