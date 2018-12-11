using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace TestAddData3.Middleware
{
    public static class CheckAdminPermissionExtension
    {
        public static IApplicationBuilder ChecAdminPermission(this IApplicationBuilder buider)
        {
            return buider.UseMiddleware<CheckAdminPermission>();
        }
    }

    public class CheckAdminPermission
    {
        private readonly RequestDelegate _next;
        public CheckAdminPermission(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            bool isAdmin = false;
            if (context.Request.Query.ContainsKey("Authorization"))
            {
                isAdmin = true;
            }

            if (isAdmin)
            {
                await _next(context);
            }

            context.Response.StatusCode = (int) HttpStatusCode.Forbidden;
            await context.Response.WriteAsync("Access Deny");
        }
    }
}
