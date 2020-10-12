using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_SVC.Repositorios;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Libro : ISVC_Libro
    {
        readonly REP_Libro _repositorio;
        public SVC_Libro()
        {
            _repositorio = new REP_Libro();
        }
        public void Delete(int id)
        {
            _repositorio.Delete(id);
        }

        public async Task<MDL_Libro> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Libro>> Get()
        {
            return await _repositorio.Get();
        }

        public void Post(MDL_Libro reg)
        {
            _repositorio.Post(reg);
        }

        public void Put(int id, MDL_Libro reg)
        {
            _repositorio.Put(id, reg);
        }
    }
}
