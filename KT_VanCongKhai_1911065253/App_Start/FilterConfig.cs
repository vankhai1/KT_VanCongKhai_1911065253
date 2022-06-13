using System.Web;
using System.Web.Mvc;

namespace KT_VanCongKhai_1911065253
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
