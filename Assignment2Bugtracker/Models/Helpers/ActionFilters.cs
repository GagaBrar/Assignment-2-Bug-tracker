using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;


namespace Assignment2Bugtracker.Models.Helpers
{
    public class ActionFilters : ActionFilterAttribute 
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Request.Browser.Crawler("(Crawler is being used)Action Executing:" + filterContext.ActionDescriptor.Crawler);

            filterContext.Result = new HttpStatusCodeResult(HttpStatusCode.Unauthorized);
            return;
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }
    }
}