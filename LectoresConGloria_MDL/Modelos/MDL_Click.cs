using System;

namespace LectoresConGloria_MDL.Modelos
{
    public class MDL_Click
    {
        public int Id { get; set; }
        public int IdTexto { get; set; }
        public int IdUsuario { get; set; }
        public int TipoClick { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
