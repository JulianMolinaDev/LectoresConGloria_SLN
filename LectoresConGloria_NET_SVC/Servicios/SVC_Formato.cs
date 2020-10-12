using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Formato : ISVC_Formato
    {
        readonly REP_Formato _repositorio;
        public SVC_Formato()
        {
            _repositorio = new REP_Formato();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public async Task<MDL_Formato> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Formato>> Get()
        {
            return await _repositorio.Get();
        }

        public void Post(MDL_Formato reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Formato reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
