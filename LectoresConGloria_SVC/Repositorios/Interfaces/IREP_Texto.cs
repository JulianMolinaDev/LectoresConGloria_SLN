using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LectoresConGloria_SVC.Repositorios.Interfaces
{
    internal interface IREP_Texto : IRepositorio<MDL_Texto, int>
    {
        Task<IEnumerable<V_Lista>> SelectUltimos();
        Task<IEnumerable<V_Lista>> SelectUltimosPorFecha(DateTime fecha);
        Task<IEnumerable<V_Lista>> SelectMasClicks();
    }
}
