using System.Web;
using System.Web.Mvc;

namespace MVC_UI_WorkOut
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
