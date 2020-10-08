namespace LectoresConGloria_SVC.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TBL_FormatosLibros
    {
        public int Id { get; set; }

        public int IdLibro { get; set; }

        public int IdFormato { get; set; }

        [Required]
        public byte[] Contenido { get; set; }

        public virtual TBL_Formatos TBL_Formatos { get; set; }

        public virtual TBL_Libros TBL_Libros { get; set; }
    }
}