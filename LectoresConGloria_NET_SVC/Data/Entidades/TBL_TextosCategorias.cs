namespace LectoresConGloria_SVC.Data.Entidades
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table(name: "TBL_TextosCategorias", Schema = "SCH_LectoresConGloria")]
    public partial class TBL_TextosCategorias
    {
        public int Id { get; set; }

        public int IdTexto { get; set; }

        public int IdCategoria { get; set; }

        public virtual TBL_Categorias TBL_Categorias { get; set; }

        public virtual TBL_Textos TBL_Textos { get; set; }
    }
}
