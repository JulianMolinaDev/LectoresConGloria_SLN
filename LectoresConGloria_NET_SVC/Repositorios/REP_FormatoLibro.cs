using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_FormatoLibro : ISVC_FormatoLibro
    {
        public void Delete(int id)
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

        public void Post(MDL_FormatoLibro reg)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, MDL_FormatoLibro reg)
        {
            throw new NotImplementedException();
        }
    }
}
