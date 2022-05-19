using System.Web;
using System.Web.Mvc;

namespace Mvc_json_and_Session__Project
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
