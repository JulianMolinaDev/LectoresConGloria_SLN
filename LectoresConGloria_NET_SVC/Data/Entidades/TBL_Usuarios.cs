namespace LectoresConGloria_SVC.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_Usuarios
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Apellidos { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Correo { get; set; }

        [Key]
        [Column(Order = 5)]
        public byte[] Password { get; set; }

        [Key]
        [Column(Order = 6, TypeName = "smalldatetime")]
        public DateTime FechaAlta { get; set; }
    }
}
