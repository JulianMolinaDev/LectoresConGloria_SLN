namespace LectoresConGloria_SVC.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_Formatos", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_Formatos
    {
        
        public TBL_Formatos()
        {
            TBL_FormatosLibros = new HashSet<TBL_FormatosLibros>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        
        public virtual ICollection<TBL_FormatosLibros> TBL_FormatosLibros { get; set; }
    }
}
