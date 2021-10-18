using CRM_for_English_School.Middleware;
using Microsoft.AspNetCore.Builder;

namespace CRM_for_English_School
{
    public static class ExceptionHandlerMiddlewareExtensions
    {
        public static void UseExceptionHandlerMiddleware(this IApplicationBuilder appBuilder)
        {
            appBuilder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
