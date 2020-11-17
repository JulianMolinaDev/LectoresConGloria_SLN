using System.Collections.Generic;

namespace LectoresConGloria_MDL.Vistas
{
    public class V_DetalleGenerico<T>
    {
        public T Padre { get; set; }
        public IEnumerable<V_Lista> Detalle { get; set; }
    }
}
