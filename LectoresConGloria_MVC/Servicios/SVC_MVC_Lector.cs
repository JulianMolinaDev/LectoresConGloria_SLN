using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_MVC.Servicios
{
    public class SVC_MVC_Lector : ISVC_Lector
    {
        private readonly SVC_Lector _servicio;
        public SVC_MVC_Lector(SVC_Lector servicio)
        {
            _servicio = servicio;
        }
        public async Task<bool> Delete(int id)
        {
            return await _servicio.Delete(id);
        }

        public async Task<MDL_Lector> Get(int id)
        {
            return await _servicio.Get(id);
        }

        public async Task<IEnumerable<MDL_Lector>> Get()
        {
            return await _servicio.Get();
        }

        public async Task<MDL_Lector> Login(MDL_Login reg)
        {
            return await _servicio.Login(reg);
        }

        public async Task<bool> Post(MDL_Lector reg)
        {
            return await _servicio.Post(reg);
        }

        public async Task<bool> Put(int id, MDL_Lector reg)
        {
            return await _servicio.Put(id, reg);
        }

        public async Task<bool> Register(MDL_Lector reg)
        {
            return await _servicio.Register(reg);
        }
    }
}
