namespace LectoresConGloria_SVC.Data
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_TextosLibros", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_TextosLibros
    {
        public int Id { get; set; }

        public int IdLibro { get; set; }

        public int IdTexto { get; set; }

        public virtual TBL_Libros TBL_Libros { get; set; }

        public virtual TBL_Textos TBL_Textos { get; set; }
    }
}
