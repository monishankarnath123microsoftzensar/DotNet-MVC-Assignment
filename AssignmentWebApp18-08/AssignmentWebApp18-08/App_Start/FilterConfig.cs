using System.Web;
using System.Web.Mvc;

namespace AssignmentWebApp18_08
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
