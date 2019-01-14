using LanguageExtensions.AspNetCore.Middlewares.ExceptionHandling;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Builder
{
    internal class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;
        private readonly IHostingEnvironment _env;

        public ExceptionHandlingMiddleware(
            RequestDelegate next,
            ILogger<ExceptionHandlingMiddleware> logger,
            IHostingEnvironment env)
        {
            _next = next;
            _logger = logger;
            _env = env;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (HttpException httpException)
            {
                _logger.LogError(new EventId(Convert.ToInt32(httpException.StatusCode)),
                    httpException,
                    httpException.Message);
                await HandleExceptionAsync(context, httpException, httpException.StatusCode);
            }
            catch (Exception ex)
            {
                _logger.LogError(500, ex, ex.Message);
                await HandleExceptionAsync(context, ex);
            }
        }

        private static Task HandleExceptionAsync(HttpContext context, Exception exception, int statusCode)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = statusCode;

            return context.Response.WriteAsync(new ErrorDetails()
            {
                StatusCode = context.Response.StatusCode,
                Message = "Internal Server Error from the custom middleware."
            }.ToString());
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception, HttpStatusCode statusCode)
            => await HandleExceptionAsync(context, exception, (int)statusCode);
        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
            => await HandleExceptionAsync(context, exception, HttpStatusCode.InternalServerError);
    }

    internal class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }


        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
