using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using LectoresConGloria_SVC.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Texto : ISVC_Texto
    {
        private readonly IREP_Texto _repositorio;
        public SVC_Texto()
        {
            _repositorio = new REP_Texto();
        }
        public async void Delete(int id)
        {
            return await _repositorio.Delete(id);
        }

        public async Task<MDL_Texto> Get(int id)
        {
            return await _repositorio.Select(id);
        }

        public async Task<IEnumerable<MDL_Texto>> Get()
        {
            return await _repositorio.Select();
        }

        public Task<V_TextoDetalle> GetDetalle(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<V_Lista>> GetMasClicks()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<V_Lista>> GetUltimos()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<V_Lista>> GetUltimosPorFecha(DateTime fecha)
        {
            throw new NotImplementedException();
        }

        public async void Post(MDL_Texto reg)
        {
            return await _repositorio.Insert(reg);
        }

        public async void Put(int id, MDL_Texto reg)
        {
            return await _repositorio.Update(id, reg);
        }
    }
}