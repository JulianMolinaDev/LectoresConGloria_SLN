using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_FormatoLibro : IServicio<MDL_FormatoLibro, int>
    {
        IEnumerable<V_Lista> GetFormatosByLibro(int idLibro);
        V_LibroDescarga GetContenido(int idFormatoLibro);
    }
}
