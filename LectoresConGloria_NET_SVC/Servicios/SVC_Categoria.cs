using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Categoria : ISVC_Categoria
    {
        readonly REP_Categoria _repositorio;
        public SVC_Categoria()
        {
            _repositorio = new REP_Categoria();
        }
        public async void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public async Task<MDL_Categoria> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Categoria>> Get()
        {
            return await _repositorio.Get();
        }

        public void Post(MDL_Categoria reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Categoria reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
