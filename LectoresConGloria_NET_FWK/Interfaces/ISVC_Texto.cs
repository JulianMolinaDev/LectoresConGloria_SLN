using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Texto : IServicio<MDL_Texto, int>
    {
        V_TextoDetalle GetDetalle(int id);
        IEnumerable<V_Lista> GetUltimosPorFecha(DateTime fecha);
        IEnumerable<V_Lista> GetUltimos();
        IEnumerable<V_Lista> GetMasClicks();
        IEnumerable<V_Lista> GetList();
    }
}
