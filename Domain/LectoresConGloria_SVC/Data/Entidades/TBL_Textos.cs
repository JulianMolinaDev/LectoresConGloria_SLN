namespace LectoresConGloria_SVC.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_Textos", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_Textos
    {
        
        public TBL_Textos()
        {
            TBL_Clicks = new HashSet<TBL_Clicks>();
            TBL_TextosCategorias = new HashSet<TBL_TextosCategorias>();
            TBL_TextosLibros = new HashSet<TBL_TextosLibros>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Titulo { get; set; }

        [Required]
        [StringLength(50)]
        public string Explicacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Audio { get; set; }

        [Required]
        [StringLength(50)]
        public string Archivo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        
        public virtual ICollection<TBL_Clicks> TBL_Clicks { get; set; }

        
        public virtual ICollection<TBL_TextosCategorias> TBL_TextosCategorias { get; set; }

        
        public virtual ICollection<TBL_TextosLibros> TBL_TextosLibros { get; set; }
    }
}
