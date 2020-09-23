using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    class SVC_TextoLibro : ISVC_TextoLibro
    {
        public Task<bool> Delete(int id)
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

        public Task<bool> Post(MDL_TextoLibro reg)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Put(int id, MDL_TextoLibro reg)
        {
            throw new NotImplementedException();
        }
    }
}
