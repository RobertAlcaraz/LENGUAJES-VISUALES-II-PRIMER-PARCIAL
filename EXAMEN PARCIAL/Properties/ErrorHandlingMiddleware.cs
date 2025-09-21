using Microsoft.AspNetCore.Http;
using System.Net;
using System.Text.Json;

namespace EXAMEN_PARCIAL.Properties
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var result = JsonSerializer.Serialize(new
                {
                    error = ex.Message,
                    status = context.Response.StatusCode
                });

                await context.Response.WriteAsync(result);
            }
        }
    }
}
