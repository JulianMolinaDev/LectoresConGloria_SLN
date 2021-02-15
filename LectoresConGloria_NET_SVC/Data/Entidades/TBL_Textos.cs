namespace LectoresConGloria_SVC.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "TBL_Textos", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_Textos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Clicks> TBL_Clicks { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_TextosCategorias> TBL_TextosCategorias { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_TextosLibros> TBL_TextosLibros { get; set; }
    }
}
