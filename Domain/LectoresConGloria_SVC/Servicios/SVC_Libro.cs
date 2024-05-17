using LectoresConGloria_FWK.Interfaces;
using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using LectoresConGloria_SVC.Repositorios;
using System.Collections.Generic;
using System.Threading.Tasks;
using LectoresConGloria_SVC.Data;

namespace LectoresConGloria_SVC.Servicios
{
    public class SVC_Libro : ISVC_Libro
    {
        readonly REP_Libro _repositorio;
        public SVC_Libro(LectoresConGloria_Context context)
        {
            _repositorio = new REP_Libro(context);
        }
        public async Task Delete(int id)
        {
            await _repositorio.Delete(id);
        }

        public async Task<MDL_Libro> Get(int id)
        {
            return await _repositorio.Get(id);
        }

        public async Task<IEnumerable<MDL_Libro>> Get()
        {
            return await _repositorio.Get();
        }

        public async Task<V_Lista> GetItem(int id)
        {
            return await _repositorio.GetItem(id);
        }

        public async Task<IEnumerable<V_Lista>> GetList()
        {
            return await _repositorio.GetList();
        }

        public async Task<IEnumerable<V_Lista>> GetListaUltimos(int cantidad)
        {
            return await _repositorio.GetListaUltimos(cantidad);
        }

        public async Task<IEnumerable<V_Lista>> GetListByNombre(string nombre)
        {
            return await _repositorio.GetListByNombre(nombre);
        }

        public async Task Post(MDL_Libro reg)
        {
            await _repositorio.Post(reg);
        }

        public async Task Put(int id, MDL_Libro reg)
        {
            await _repositorio.Put(id, reg);
        }
    }
}
