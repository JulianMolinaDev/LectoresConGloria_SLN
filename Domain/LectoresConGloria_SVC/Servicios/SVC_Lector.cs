using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Lector : ISVC_Lector
    {
        readonly REP_Lector _repositorio;
        public SVC_Lector(LectoresConGloria_Context context)
        {
            _repositorio = new REP_Lector(context);
        }
        public async Task Delete(int id)
        {
            await _repositorio.Delete(id);
        }

        public async Task<MDL_Lector> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Lector>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<MDL_Lector> Login(MDL_Login reg)
        {
            return await _repositorio.Login(reg);
        }

        public async Task Post(MDL_Lector reg)
        {
            await _repositorio.Post(reg);
        }

        public async Task Put(int id, MDL_Lector reg)
        {
            await _repositorio.Put(id, reg);
        }

        public async Task Register(MDL_Lector reg)
        {
            await _repositorio.Register(reg);
        }
    }

}
