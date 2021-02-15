using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;

namespace LectoresConGloria_SVC.Interfaces
{
    public interface ISVC_FormatoLibro : IServicio<MDL_FormatoLibro, int>
    {
        IEnumerable<V_ListaRelacion> GetFormatosByLibro(int idLibro);
        IEnumerable<V_ListaRelacion> GetLibrosByFormato(int idFormato);
        V_LibroDescarga GetContenido(int idFormatoLibro);
        IEnumerable<V_Lista> FaltantesFormatosByLibro(int idLibro);
        V_Lista GetLibroAsItem(int idFormatoLibro);
        V_Lista GetFormatoAsItem(int idFormatoLibro);
        void CambiarContenido(int idFormatoLibro, string contenido);
        void CambiarFormato(int idFormatoLibro, int idFormato);
        V_AsociacionDetalle GetAsociacionDetalle(int id);
    }
}
