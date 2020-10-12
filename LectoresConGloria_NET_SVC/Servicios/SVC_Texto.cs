using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Texto : ISVC_Texto
    {
        private readonly REP_Texto _repositorio;
        public SVC_Texto()
        {
            _repositorio = new REP_Texto();
        }
        public async void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public async Task<MDL_Texto> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Texto>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<V_TextoDetalle> GetDetalle(int id)
        {
            return await _repositorio.GetDetalle(id);
        }

        public async Task<IEnumerable<V_Lista>> GetMasClicks()
        {
            return await _repositorio.GetMasClicks();
        }

        public async Task<IEnumerable<V_Lista>> GetUltimos()
        {
            return await _repositorio.GetUltimos();
        }

        public async Task<IEnumerable<V_Lista>> GetUltimosPorFecha(DateTime fecha)
        {
            return await _repositorio.GetUltimosPorFecha(fecha);
        }

        public async void Post(MDL_Texto reg)
        {
           _repositorio.Post(reg);
        }

        public async void Put(int id, MDL_Texto reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}