using System.Web;
using System.Web.Mvc;

namespace LectoresConGloria_MVC_ADM
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
