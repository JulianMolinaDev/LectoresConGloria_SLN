using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Texto: IServicio<MDL_Texto, int>
    {
        Task<IEnumerable<V_Lista>> GetUltimosPorFecha(DateTime fecha);
        Task<IEnumerable<V_Lista>> GetUltimos();
        Task<IEnumerable<V_Lista>> GetMasClicks();
    }
}
