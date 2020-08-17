using ASPNetDocker.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace ASPNetDocker.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UsePing(this IApplicationBuilder app)
        {
            return app.Map("/ping", x => x.Run(async conext => await conext.Response.WriteAsync("pong")));
        }

        public static IApplicationBuilder UseCustomCors(this IApplicationBuilder app)
        {
            return app.UseMiddleware<CorsMiddleware>();
        }

        public static IApplicationBuilder UseDefaultExceptionHandler(this IApplicationBuilder app)
        {
            return app.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
