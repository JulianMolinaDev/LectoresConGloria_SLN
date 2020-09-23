using System;
using System.Collections.Generic;
using System.Text;

namespace LectoresConGloria_SVC.Data.Entidades
{
    public class TBL_Textos
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Explicacion { get; set; }
        public string Audio { get; set; }
        public string Archivo { get; set; }
        public DateTime FechaAlta { get; set; }
        public ICollection<TBL_Clicks> Clicks { get; set; }
    }
}
