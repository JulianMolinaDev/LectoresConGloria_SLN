using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Formato : IServicio<MDL_Formato, int>
    {
        IEnumerable<V_Lista> GetList();
        V_Lista GetItem(int id);
    }
}
