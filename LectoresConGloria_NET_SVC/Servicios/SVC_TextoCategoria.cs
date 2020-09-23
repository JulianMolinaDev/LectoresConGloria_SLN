using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    class SVC_TextoCategoria : ISVC_TextoCategoria
    {
        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MDL_TextoCategoria> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MDL_TextoCategoria>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<V_Lista>> GetCategoriaPorTexto(int idTexto)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<V_Lista>> GetTextoPorCategoria(int idCategoria)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Post(MDL_TextoCategoria reg)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Put(int id, MDL_TextoCategoria reg)
        {
            throw new NotImplementedException();
        }
    }
}
