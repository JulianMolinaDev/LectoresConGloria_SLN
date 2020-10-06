using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios
{
    class REP_Formato : ISVC_Formato
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MDL_Formato> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MDL_Formato>> Get()
        {
            throw new NotImplementedException();
        }

        public void Post(MDL_Formato reg)
        {
            throw new NotImplementedException();
        }

        public void Put(int id, MDL_Formato reg)
        {
            throw new NotImplementedException();
        }
    }
}
