using System;
using System.Web.Mvc;
namespace STA.SuperCompra.Infra.CrossCutting.MvcFilters
{
    public class GlobalErrorHandler: ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            // Gravar Log
            try
            {
                base.OnActionExecuting(filterContext);
            }
            catch (Exception ex)
            {
                // Log ex
                throw ex;
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Exception != null)
            {
                // Tratar o erro de alguma forma
                // 1 - Gravar no EventViewer
                // 2 - Gravar no banco
                // 3 - Enviar um email
                // 4 - Fazer tudo isso e mais alguma coisa.

                // Muitos recursos disponíveis para montar um LOG completo
                // filterContext.Controller.ControllerContext.HttpContext;
                // filterContext.Exception;
                //filterContext.Controller.TempData["ErrorMessage"] = filterContext.Exception.Message;
            }
            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

    }
}
