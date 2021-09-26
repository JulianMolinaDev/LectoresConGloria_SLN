namespace LectoresConGloria_MVC_ADM.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SCH_LectoresConGloria.TBL_TextosLibros")]
    public partial class TBL_TextosLibros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int IdLibro { get; set; }

        public int IdTexto { get; set; }

        public virtual TBL_Libros TBL_Libros { get; set; }

        public virtual TBL_Textos TBL_Textos { get; set; }
    }
}
