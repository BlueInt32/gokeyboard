using System.Web;
using System.Web.Mvc;
using Tools.Filters;

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
