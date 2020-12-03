using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Interfaces
{
    public interface ISVC_Texto : IServicio<MDL_Texto, int>
    {
        V_TextoDetalle GetDetalle(int id);
        IEnumerable<V_TextoLista> GetListaUltimosPorFecha(DateTime fecha);
        IEnumerable<V_TextoLista> GetListaUltimos();
        IEnumerable<V_TextoLista> GetListaMasClicks();
        IEnumerable<V_Lista> GetList();
        IEnumerable<V_Lista> GetListaPorTitulo(string titulo);
        IEnumerable<MDL_Texto> GetUltimos(int cantidad);
        V_Lista GetItem(int id);
    }
}
