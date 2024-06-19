using Microsoft.AspNetCore.Mvc.Filters;
using Shop.Services.Interfaces;

namespace Shop.Filters
{
    public class ExceptionLoggingFilter : IExceptionFilter
    {
        private readonly ILoggingService _loggingService;

        public ExceptionLoggingFilter(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void OnException(ExceptionContext context)
        {
            var message = $"Exception occurred: {context.Exception.Message}";
            _loggingService.Log(message, "exceptions.log");
        }
    }
}
