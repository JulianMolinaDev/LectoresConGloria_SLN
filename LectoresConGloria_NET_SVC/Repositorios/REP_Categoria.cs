using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Data;
using LectoresConGloria_SVC.Repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Categoria : IREP_Categoria
    {
        LectoresConGloria_Context _contexto;
        public REP_Categoria()
        {
            _contexto = new LectoresConGloria_Context();
        }
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MDL_Categoria> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MDL_Categoria>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Post(MDL_Categoria reg)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Put(int id, MDL_Categoria reg)
        {
            throw new NotImplementedException();
        }
    }
}
