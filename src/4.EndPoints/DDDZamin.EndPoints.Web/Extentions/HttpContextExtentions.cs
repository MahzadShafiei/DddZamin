using DDDZamin.Core.Contract.ApplicationServices.Commands;
using DDDZamin.Core.Contract.ApplicationServices.Events;
using DDDZamin.Core.Contract.ApplicationServices.Queries;
using DDDZamin.Utilities;
using Microsoft.AspNetCore.Http;

namespace DDDZamin.EndPoints.Web.Extentions
{
    public static class HttpContextExtensions
    {
        public static ICommandDispatcher CommandDispatcher(this HttpContext httpContext) =>
            (ICommandDispatcher)httpContext.RequestServices.GetService(typeof(ICommandDispatcher));

        public static IQueryDispatcher QueryDispatcher(this HttpContext httpContext) =>
            (IQueryDispatcher)httpContext.RequestServices.GetService(typeof(IQueryDispatcher));
        public static IEventDispatcher EventDispatcher(this HttpContext httpContext) =>
            (IEventDispatcher)httpContext.RequestServices.GetService(typeof(IEventDispatcher));
        public static ZaminServices ZaminApplicationContext(this HttpContext httpContext) =>
            (ZaminServices)httpContext.RequestServices.GetService(typeof(ZaminServices));
    }
}
