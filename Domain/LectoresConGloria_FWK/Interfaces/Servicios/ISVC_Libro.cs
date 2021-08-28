using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Libro : IServicio<MDL_Libro, int>
    {
        IEnumerable<V_Lista> GetList();
        IEnumerable<V_Lista> GetListByNombre(string nombre);
        IEnumerable<V_Lista> GetListaUltimos(int cantidad);
        V_Lista GetItem(int id);
    }
}
