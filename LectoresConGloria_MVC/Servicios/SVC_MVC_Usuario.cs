using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_MVC.Servicios
{
    public class SVC_MVC_Usuario : ISVC_Usuario
    {
        private readonly SVC_Usuario _servicio;
        public SVC_MVC_Usuario(SVC_Usuario servicio)
        {
            _servicio = servicio;
        }
        public async Task<bool> Delete(int id)
        {
            return await _servicio.Delete(id);
        }

        public async Task<MDL_Usuario> Get(int id)
        {
            return await _servicio.Get(id);
        }

        public async Task<IEnumerable<MDL_Usuario>> Get()
        {
            return await _servicio.Get();
        }

        public async Task<MDL_Usuario> Login(MDL_Login reg)
        {
            return await _servicio.Login(reg);
        }

        public async Task<bool> Post(MDL_Usuario reg)
        {
            return await _servicio.Post(reg);
        }

        public async Task<bool> Put(int id, MDL_Usuario reg)
        {
            return await _servicio.Put(id, reg);
        }

        public async Task<bool> Register(MDL_Usuario reg)
        {
            return await _servicio.Register(reg);
        }
    }
}
