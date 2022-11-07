using System.Web;
using System.Web.Mvc;

namespace WeatherApp_u
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) { filters.Add(new HandleErrorAttribute()); }
    }
}