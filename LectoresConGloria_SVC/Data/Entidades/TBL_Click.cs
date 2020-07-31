using System;
using System.Collections.Generic;
using System.Text;

namespace LectoresConGloria_SVC.Data.Entidades
{
    class TBL_Click
    {
        public int Id { get; set; }
        public int IdTexto { get; set; }
        public int TipoClick { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}
