using System.Web;
using System.Web.Mvc;

namespace WebApplicationDemo_kudvenkat_youtube
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
