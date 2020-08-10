using System;
using System.Collections.Generic;
using System.Text;

namespace LectoresConGloria_SVC.Data.Entidades
{
    public class TBL_Clicks
    {
        public int Id { get; set; }
        public int IdTexto { get; set; }
        public int IdUsuario { get; set; }
        public int TipoClick { get; set; }
        public DateTime FechaAlta { get; set; }
        public TBL_Usuarios Usuario { get; set; }
        public TBL_Textos Texto { get; set; }
    }
}
