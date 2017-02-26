using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace STA.SuperCompra.UI.Mvc.Infraestrutura.Helpers
{
    public static class HelperFactory
    {
        public static CustomHelpers STA(this HtmlHelper helper)
        {
            return new CustomHelpers(helper);
        }

    }
}