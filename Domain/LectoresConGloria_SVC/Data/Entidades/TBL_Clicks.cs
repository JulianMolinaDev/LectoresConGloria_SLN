namespace LectoresConGloria_SVC.Data
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_Clicks", Schema = "SCH_LectoresConGloria")]
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
