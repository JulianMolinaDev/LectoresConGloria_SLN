using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_TextoCategoria : IServicio<MDL_TextoCategoria, int>
    {
        Task<IEnumerable<V_Lista>> GetTextoPorCategoria(int idCategoria);
        Task<IEnumerable<V_Lista>> GetCategoriaPorTexto(int idTexto);
    }
}
