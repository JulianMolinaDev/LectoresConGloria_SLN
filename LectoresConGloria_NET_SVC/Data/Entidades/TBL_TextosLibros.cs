namespace LectoresConGloria_SVC.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "TBL_TextosLibros", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_TextosLibros
    {
        public int Id { get; set; }

        public int IdLibro { get; set; }

        public int IdTexto { get; set; }

        public virtual TBL_Libros TBL_Libros { get; set; }

        public virtual TBL_Textos TBL_Textos { get; set; }
    }
}
