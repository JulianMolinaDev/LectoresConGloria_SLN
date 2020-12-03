using System.Web;

namespace LectoresConGloria_NET_MVC.Constantes
{
    public static class Globales
    {
        public static string pathToFiles = HttpContext.Current.Server.MapPath("/UploadedFiles");
    }
}