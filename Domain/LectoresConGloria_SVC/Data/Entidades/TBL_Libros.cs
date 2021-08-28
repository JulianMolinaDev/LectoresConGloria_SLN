namespace LectoresConGloria_SVC.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_Libros", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_Libros
    {
        
        public TBL_Libros()
        {
            TBL_FormatosLibros = new HashSet<TBL_FormatosLibros>();
            TBL_TextosLibros = new HashSet<TBL_TextosLibros>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Imagen { get; set; }

        
        public virtual ICollection<TBL_FormatosLibros> TBL_FormatosLibros { get; set; }

        
        public virtual ICollection<TBL_TextosLibros> TBL_TextosLibros { get; set; }
    }
}
