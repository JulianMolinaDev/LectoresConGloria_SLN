using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
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
        public async Task<bool> Delete(int id)
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

        public async Task<bool> Post(MDL_Texto reg)
        {
            return await _repositorio.Insert(reg);
        }

        public async Task<bool> Put(int id, MDL_Texto reg)
        {
            return await _repositorio.Update(id, reg);
        }
    }
}