namespace LectoresConGloria_SVC.Data.Entidades
{
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_TextosCategorias", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_TextosCategorias
    {
        public int Id { get; set; }

        public int IdTexto { get; set; }

        public int IdCategoria { get; set; }

        public virtual TBL_Categorias TBL_Categorias { get; set; }

        public virtual TBL_Textos TBL_Textos { get; set; }
    }
}
