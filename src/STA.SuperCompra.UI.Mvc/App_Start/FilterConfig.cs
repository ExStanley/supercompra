using STA.SuperCompra.Infra.CrossCutting.MvcFilters;
using System.Web;
using System.Web.Mvc;

namespace STA.SuperCompra.UI.Mvc
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new GlobalErrorHandler());
        }
    }
}
