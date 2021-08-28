using System.Collections.Generic;

namespace LectoresConGloria_MDL.Vistas
{
    public class V_DetalleItemLista
    {
        public V_Lista Padre { get; set; }
        public IEnumerable<V_Lista> Detalle { get; set; }
    }
}
