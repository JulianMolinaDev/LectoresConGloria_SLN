namespace LectoresConGloria_SVC.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table(name: "TBL_Lectores", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_Lectores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_Lectores()
        {
            TBL_Clicks = new HashSet<TBL_Clicks>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Correo { get; set; }

        [Required]
        public byte[] Password { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Clicks> TBL_Clicks { get; set; }
    }
}
