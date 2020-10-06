using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_TextoLibro : ISVC_TextoLibro
    {
        readonly REP_TextoLibro _repositorio;
        public SVC_TextoLibro()
        {
            _repositorio = new REP_TextoLibro();
        }
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
            return _repositorio.GetTextosPorLibro(idLibro);
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
