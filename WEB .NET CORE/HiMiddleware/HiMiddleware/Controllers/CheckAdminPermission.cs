using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HiMiddleware.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace HiMiddleware.Controllers
{
    public static class CheckAdminPermissionExtensions
    {
        public static IApplicationBuilder CheckAdminPermission(
            this IApplicationBuilder builder)
        {
            //return app => app.UseMiddleware<CheckAdminPermission>();
            return builder.UseMiddleware<CheckAdminPermission>();
        }
    }
    public class CheckAdminPermission
    {
        private readonly RequestDelegate _next;

        public CheckAdminPermission(RequestDelegate next)
        {
            _next = next;            
        }

        public async Task InvokeAsync(HttpContext context, HiMiddlewareContext dbContext)
        {
            var isAuthen = false;
            if (context.Request.Headers.ContainsKey("Authorization"))
            {
                var tokenKey = context.Request.Headers["Authorization"].ToString(); // Basic token_key
                tokenKey = tokenKey.Replace("Basic ", "");
                var credential = await dbContext.Credential.SingleOrDefaultAsync(t => t.AccessToken == tokenKey);
                if (credential != null && credential.IsValid())
                {
                    isAuthen = true;
                }
            }

            if (isAuthen)
            {
                await _next.Invoke(context);
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                await context.Response.WriteAsync("Access Deny");
            }
        }

    }
}
