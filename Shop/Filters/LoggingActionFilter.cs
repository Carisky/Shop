using Microsoft.AspNetCore.Mvc.Filters;
using Shop.Services.Interfaces;

namespace Shop.Filters
{
    public class LoggingActionFilter : IActionFilter
    {
        private readonly ILoggingService _loggingService;

        public LoggingActionFilter(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            // Записываем лог перед выполнением действия
            var message = $"Executing action: {context.ActionDescriptor.DisplayName}";
            _loggingService.Log(message, "requests.log");
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Можно добавить логирование после выполнения действия, если необходимо
        }
    }
}
