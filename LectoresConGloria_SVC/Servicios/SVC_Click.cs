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
    public class SVC_Click : ISVC_Click
    {
        private readonly IREP_Click _repositorio;
        public SVC_Click()
        {
            _repositorio = new REP_Click();
        }
        public async Task<bool> Delete(int id)
        {
            return await _repositorio.Delete(id);
        }

        public async Task<MDL_Click> Get(int id)
        {
            return await _repositorio.Select(id);
        }

        public async Task<IEnumerable<MDL_Click>> Get()
        {
            return await _repositorio.Select();
        }

        public async Task<bool> Post(MDL_Click reg)
        {
            return await _repositorio.Insert(reg);
        }

        public async Task<bool> Put(int id, MDL_Click reg)
        {
            return await _repositorio.Update(id, reg);
        }
    }
}
