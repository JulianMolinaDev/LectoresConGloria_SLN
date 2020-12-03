using LectoresConGloria_MDL.Modelos;
using LectoresConGloria_MDL.Vistas;

namespace LectoresConGloria_NET_MVC_ADM.Models
{
    public class VM_TextoDesdeLibro
    {
        public int idLibro { get; set; }
        public MDL_Texto Texto { get; set; }
    }
}