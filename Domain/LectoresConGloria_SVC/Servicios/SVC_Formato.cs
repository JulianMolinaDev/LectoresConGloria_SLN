using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Formato : ISVC_Formato
    {
        readonly REP_Formato _repositorio;
        public SVC_Formato(LectoresConGloria_Context context)
        {
            _repositorio = new REP_Formato(context);
        }
        public async Task Delete(int id)
        {
            await _repositorio.Delete(id);
        }

        public async Task<MDL_Formato> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Formato>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<V_Lista> GetItem(int id)
        {
            return await _repositorio.GetItem(id);
        }

        public async Task<IEnumerable<V_Lista>> GetList()
        {
            return await _repositorio.GetList();
        }

        public async Task Post(MDL_Formato reg)
        {
            await _repositorio.Post(reg);
        }

        public async Task Put(int id, MDL_Formato reg)
        {
            await _repositorio.Put(id, reg);
        }
    }
}
