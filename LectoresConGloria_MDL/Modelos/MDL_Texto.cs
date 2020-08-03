using System;

namespace LectoresConGloria_MDL.Modelos
{
    public class MDL_Texto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Explicacion { get; set; }
        public string Audio { get; set; }
        public string Archivo { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
