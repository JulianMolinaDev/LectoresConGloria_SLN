using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_FormatoLibro : IServicio<MDL_FormatoLibro, int>
    {
        Task<IEnumerable<V_ListaRelacion>> GetFormatosByLibro(int idLibro);
        Task<IEnumerable<V_ListaRelacion>> GetLibrosByFormato(int idFormato);
        Task<V_LibroDescarga> GetContenido(int idFormatoLibro);
        Task<IEnumerable<V_Lista>> GetFaltantesFormatosByLibro(int idLibro);
        Task<V_Lista> GetLibroAsItem(int idFormatoLibro);
        Task<V_Lista> GetFormatoAsItem(int idFormatoLibro);
        Task CambiarContenido(int idFormatoLibro, string contenido);
        Task CambiarFormato(int idFormatoLibro, int idFormato);
        Task<V_AsociacionDetalle> GetAsociacionDetalle(int id);
    }
}
