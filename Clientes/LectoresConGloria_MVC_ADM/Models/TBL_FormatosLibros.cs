namespace LectoresConGloria_MVC_ADM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCH_LectoresConGloria.TBL_FormatosLibros")]
    public partial class TBL_FormatosLibros
    {
        public int Id { get; set; }

        public int IdLibro { get; set; }

        public int IdFormato { get; set; }

        [Required]
        [StringLength(50)]
        public string Archivo { get; set; }

        public virtual TBL_Formatos TBL_Formatos { get; set; }

        public virtual TBL_Libros TBL_Libros { get; set; }
    }
}
