using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Texto : IServicio<MDL_Texto, int>
    {
        Task<V_TextoDetalle> GetDetalle(int id);
        Task<IEnumerable<V_TextoLista>> GetListaUltimosPorFecha(DateTime fecha);
        Task<IEnumerable<V_TextoLista>> GetListaUltimos();
        Task<IEnumerable<V_TextoLista>> GetListaMasClicks();
        Task<IEnumerable<V_Lista>> GetList();
        Task<IEnumerable<V_Lista>> GetListaPorTitulo(string titulo);
        Task<IEnumerable<MDL_Texto>> GetUltimos(int cantidad);
        Task<V_Lista> GetItem(int id);
    }
}
