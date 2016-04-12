using System.Web;
using System.Web.Mvc;

namespace architecture_unity_layered_codefirts
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
