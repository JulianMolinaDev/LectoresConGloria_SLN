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
    class REP_TextoLibro : ISVC_TextoLibro
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MDL_TextoLibro> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MDL_TextoLibro>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<V_Lista>> GetTextosPorLibro(int idLibro)
        {
            throw new NotImplementedException();
        }

        public void Post(MDL_TextoLibro reg)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, MDL_TextoLibro reg)
        {
            throw new NotImplementedException();
        }
    }
}
