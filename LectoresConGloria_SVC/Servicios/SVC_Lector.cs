using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Lector : ISVC_Lector
    {
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<MDL_Lector> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MDL_Lector>> Get()
        {
            throw new NotImplementedException();
        }

        public async Task<MDL_Lector> Login(MDL_Login reg)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Post(MDL_Lector reg)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Put(int id, MDL_Lector reg)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Register(MDL_Lector reg)
        {
            throw new NotImplementedException();
        }
    }
}
