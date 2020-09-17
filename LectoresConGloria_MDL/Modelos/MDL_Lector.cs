using System;

namespace LectoresConGloria_MDL.Modelos
{
    public class MDL_Lector
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Correo { get; set; }
        public byte[] Password { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
