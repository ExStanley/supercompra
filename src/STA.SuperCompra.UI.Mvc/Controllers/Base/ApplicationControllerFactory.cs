using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace STA.SuperCompra.UI.Mvc.Controllers.Base
{
    public class ApplicationControllerFactory : IControllerFactory
    {
        private string Namespace
        {
            get
            {
                return this.GetType().Namespace;
            }
        }

        public IController CreateController(RequestContext requestContext, string controllerName)
        {
            if (string.IsNullOrEmpty(controllerName))
                throw new ArgumentNullException("controllerName");

            Type cType = Type.GetType(Namespace + ".Controllers." + controllerName + "Controller");

            if (cType == null)
            {
                cType = Type.GetType(Namespace + ".Library.ApplicationController`1[" + Namespace + ".Models." + controllerName + "]");
            }

            return Activator.CreateInstance(cType) as Controller;
        }

        public void ReleaseController(IController controller)
        {
            if (controller is IDisposable)
                (controller as IDisposable).Dispose();
            else
                controller = null;
        }

        public System.Web.SessionState.SessionStateBehavior GetControllerSessionBehavior(RequestContext requestContext, string controllerName)
        {
            return System.Web.SessionState.SessionStateBehavior.Default;
        }
    }
}