namespace LectoresConGloria_MVC_ADM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCH_LectoresConGloria.TBL_Clicks")]
    public partial class TBL_Clicks
    {
        public int Id { get; set; }

        public int IdTexto { get; set; }

        public int IdLector { get; set; }

        public int TipoClick { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        public virtual TBL_Lectores TBL_Lectores { get; set; }

        public virtual TBL_Textos TBL_Textos { get; set; }
    }
}
