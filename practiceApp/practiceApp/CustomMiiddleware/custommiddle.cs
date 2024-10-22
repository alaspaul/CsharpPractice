
namespace practiceApp.CustomMiiddleware
{
    public class custommiddle : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync(" custom middelware starts  ");

            await next(context);

            await context.Response.WriteAsync(" custom middelware ends  ");
        }
    }

    public static class CustomMiddlewareExt
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder app)
        {
            return app.UseMiddleware<custommiddle>();
        }
    }
    
}
