using BlueInt32.Mvc.ActionFilters;
using System.Web;
using System.Web.Mvc;

namespace GoKeyboardRest.Api
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new LogExceptionFilter());
        }
    }
}
