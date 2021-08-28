namespace LectoresConGloria_SVC.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_FormatosLibros", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_FormatosLibros
    {
        public int Id { get; set; }

        public int IdLibro { get; set; }

        public int IdFormato { get; set; }

        [StringLength(50)]
        public string Archivo { get; set; }

        public virtual TBL_Formatos TBL_Formatos { get; set; }

        public virtual TBL_Libros TBL_Libros { get; set; }
    }
}
