using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using System.Threading.Tasks;

namespace practiceApp.CustomMiiddleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class LoginMiddleware
    {
        private readonly RequestDelegate _next;

        public LoginMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            if((httpContext.Request.Path == "/") && (httpContext.Request.Method == "POST"))
            {
                StreamReader reader = new StreamReader(httpContext.Request.Body);
                string Body = await reader.ReadToEndAsync();

                Dictionary<string, StringValues> query = Microsoft.AspNetCore.WebUtilities.QueryHelpers.ParseQuery(Body);

                string? email = null, password = null;

                if (query.ContainsKey("email"))
                {
                    email = Convert.ToString(query["email"][0]);
                }
                else
                {
                    httpContext.Response.StatusCode = 400;
                    await httpContext.Response.WriteAsync("invalid inpput - email\n");
                }

                if (query.ContainsKey("password"))
                {
                    password = Convert.ToString(query["password"][0]);
                }
                else
                {
                    httpContext.Response.StatusCode = 400;
                    await httpContext.Response.WriteAsync("invalid inpput - password\n");
                }


                if (string.IsNullOrEmpty(email) == false && string.IsNullOrEmpty(password) == false)
                {
                    if (email == "admin@example.com" && password == "admin1234")
                    {
                        httpContext.Response.StatusCode = 200;
                        await httpContext.Response.WriteAsync("successful login\n");
                    }
                    else
                    {
                        httpContext.Response.StatusCode = 400;
                        await httpContext.Response.WriteAsync("invalid credentials\n");
                    }
                }
                else 
                {

                    httpContext.Response.StatusCode = 400;
                    if (string.IsNullOrEmpty(email) == true)
                    {
                        await httpContext.Response.WriteAsync("invalid inpput - email\n");
                    }

                    if (string.IsNullOrEmpty(password) == true)
                    {
                        await httpContext.Response.WriteAsync("invalid inpput - password\n");
                    }

                }
                


            }
            else
            {
                httpContext.Response.StatusCode = 200;
            }

            await _next(httpContext);
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class LoginMiddlewareExtensions
    {
        public static IApplicationBuilder UseLoginMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<LoginMiddleware>();
        }
    }
}
