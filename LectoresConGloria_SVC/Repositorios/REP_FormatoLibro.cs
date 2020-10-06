using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_FormatoLibro : ISVC_FormatoLibro
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MDL_FormatoLibro> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MDL_FormatoLibro>> Get()
        {
            throw new NotImplementedException();
        }

        public V_LibroDescarga GetContenido(int idFormatoLibro)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<V_Lista> GetListaByLibro(int idLibro)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Post(MDL_FormatoLibro reg)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Put(int id, MDL_FormatoLibro reg)
        {
            throw new NotImplementedException();
        }
    }
}
