using System.Web;
using System.Web.Mvc;

namespace CSCI467PlaceOrderMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
