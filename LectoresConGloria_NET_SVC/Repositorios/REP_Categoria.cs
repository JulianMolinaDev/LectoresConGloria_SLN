using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Categoria : ISVC_Categoria
    {
        readonly LectoresConGloria_Context _contexto;
        public REP_Categoria()
        {
            _contexto = new LectoresConGloria_Context();
        }
        public void Delete(int id)
        {
            var entity = _contexto.TBL_Categorias.Find(id);
            _contexto.TBL_Categorias.Remove(entity);

        }

        public Task<MDL_Categoria> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MDL_Categoria>> Get()
        {
            throw new NotImplementedException();
        }

        public void Post(MDL_Categoria reg)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, MDL_Categoria reg)
        {
            throw new NotImplementedException();
        }
    }
}
