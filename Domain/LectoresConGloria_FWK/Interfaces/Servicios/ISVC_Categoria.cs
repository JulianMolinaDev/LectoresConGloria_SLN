﻿using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LectoresConGloria_FWK.Interfaces
{
    public interface ISVC_Categoria : IServicio<MDL_Categoria, int>
    {
        Task<IEnumerable<V_Lista>> GetList();
        Task<V_Lista> GetItem(int id);
    }
}
