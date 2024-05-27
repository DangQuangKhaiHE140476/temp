using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace QLHSC07.Infrastructure.Exceptions
{
    public class BaseExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
