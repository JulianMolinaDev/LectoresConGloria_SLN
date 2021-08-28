using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Categoria : IServicio<MDL_Categoria, int>
    {
        IEnumerable<V_Lista> GetList();
        V_Lista GetItem(int id);
    }
}
