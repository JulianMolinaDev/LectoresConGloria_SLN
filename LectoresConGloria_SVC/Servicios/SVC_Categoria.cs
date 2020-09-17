using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    class SVC_Categoria : ISVC_Categoria
    {
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
