using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_TextoCategoria : IServicio<MDL_TextoCategoria, int>
    {
        IEnumerable<V_ListaRelacion> GetTextoPorCategoria(int idCategoria);
        IEnumerable<V_ListaRelacion> GetCategoriaPorTexto(int idTexto);
        IEnumerable<V_Lista> GetFaltantesCategoriasPorTexto(int idTexto);
        V_AsociacionDetalle GetAsociacionDetalle(int id);
    }
}
