using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_TextoLibro : IServicio<MDL_TextoLibro, int>
    {
        Task<IEnumerable<V_Lista>> GetTextosPorLibro(int idLibro);
    }
}
