using System;
using System.Collections.Generic;
using System.Text;

namespace LectoresConGloria_SVC.Data.Entidades
{
    class TBL_Usuario
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
