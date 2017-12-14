using System.Web;
using System.Web.Mvc;

namespace IHC_Nurse_Hours
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
