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
            _repositorio.Delete(id);
        }

        public async Task<MDL_TextoLibro> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_TextoLibro>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<IEnumerable<V_Lista>> GetTextosPorLibro(int idLibro)
        {
            return await _repositorio.GetTextosPorLibro(idLibro);
        }

        public void Post(MDL_TextoLibro reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_TextoLibro reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
