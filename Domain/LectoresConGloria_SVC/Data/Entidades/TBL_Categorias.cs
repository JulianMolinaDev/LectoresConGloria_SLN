namespace LectoresConGloria_SVC.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_Categorias" ,Schema = "SCH_LectoresConGloria")]
    public partial class TBL_Categorias
    {
        public TBL_Categorias()
        {
            TBL_TextosCategorias = new HashSet<TBL_TextosCategorias>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        
        public virtual ICollection<TBL_TextosCategorias> TBL_TextosCategorias { get; set; }
    }
}
