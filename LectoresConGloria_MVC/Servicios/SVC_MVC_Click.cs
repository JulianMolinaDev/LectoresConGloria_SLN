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
        public async Task<bool> Delete(int id)
        {
            return await _servicio.Delete(id);
        }

        public async Task<MDL_Click> Get(int id)
        {
            return await _servicio.Get(id);
        }

        public async Task<IEnumerable<MDL_Click>> Get()
        {
            return await _servicio.Get();
        }

        public async Task<bool> Post(MDL_Click reg)
        {
            return await _servicio.Post(reg);
        }

        public async Task<bool> Put(int id, MDL_Click reg)
        {
            return await _servicio.Put(id, reg);
        }
    }
}
