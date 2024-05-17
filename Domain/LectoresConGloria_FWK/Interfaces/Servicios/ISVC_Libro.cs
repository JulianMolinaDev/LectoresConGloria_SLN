using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Libro : IServicio<MDL_Libro, int>
    {
        Task<IEnumerable<V_Lista>> GetList();
        Task<IEnumerable<V_Lista>> GetListByNombre(string nombre);
        Task<IEnumerable<V_Lista>> GetListaUltimos(int cantidad);
        Task<V_Lista> GetItem(int id);
    }
}
