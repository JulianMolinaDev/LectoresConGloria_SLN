using System.ComponentModel.DataAnnotations;
using System.Web;

namespace LectoresConGloria_NET_MVC_ADM.Models
{
    public class VM_FormatoLibro
    {
        [Required]
        public HttpPostedFile Archivo { get; set; }
        [Required]
        [Display(Name = "Formato")]
        public int IdFormato { get; set; }
        public int IdLibro { get; set; }
    }
}