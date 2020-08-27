using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LectoresConGloria_MVC_ADM.Servicios
{
    public class SVC_MVC_Texto : ISVC_Texto
    {
        private readonly ISVC_Texto _servicio;
        public SVC_MVC_Texto(ISVC_Texto servicio)
        {
            _servicio = servicio;
        }
        public Task<bool> Delete(int id)
        {
            return _servicio.Delete(id);
        }

        public Task<MDL_Texto> Get(int id)
        {
            return _servicio.Get(id);
        }

        public Task<IEnumerable<MDL_Texto>> Get()
        {
            return _servicio.Get();
        }

        public Task<V_TextoDetalle> GetDetalle(int id)
        {
            return _servicio.GetDetalle(id);
        }

        public Task<IEnumerable<V_Lista>> GetMasClicks()
        {
            return _servicio.GetMasClicks();
        }

        public Task<IEnumerable<V_Lista>> GetUltimos()
        {
            return _servicio.GetUltimos();
        }

        public Task<IEnumerable<V_Lista>> GetUltimosPorFecha(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Post(MDL_Texto reg)
        {
            return _servicio.Post(reg);
        }

        public Task<bool> Put(int id, MDL_Texto reg)
        {
            return _servicio.Put(id, reg);
        }
    }
}
