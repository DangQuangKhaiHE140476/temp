using QLHSC07.Infrastructure.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace QLHSC07.ApiGateway.Middlewares
{
    public class ErrorHandling
    {
        private readonly RequestDelegate _next;
        private readonly ILogger _logger;

        public ErrorHandling(RequestDelegate next, ILogger<ErrorHandling> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context /* other dependencies */)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";
            dynamic error = new ExpandoObject();
            error.Message = exception.InnerException?.Message ?? exception.Message;

             if (exception is LoginFailedException)
            {
                error.Code = (int)HttpStatusCode.BadRequest;
                _logger.LogError(exception, "Có lỗi xảy ra trong quá trình login!");
            }
            else
            {
                error.Code = (int)HttpStatusCode.InternalServerError;
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                _logger.LogError(exception, "unknown error");
            }
            await context.Response.WriteAsync(Newtonsoft.Json.JsonConvert.SerializeObject((object)error));
        }
    }
}
