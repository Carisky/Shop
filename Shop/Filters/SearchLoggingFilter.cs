using Microsoft.AspNetCore.Mvc.Filters;
using Shop.Services.Interfaces;

namespace Shop.Filters
{
    public class SearchLoggingFilter : IActionFilter
    {
        private readonly ILoggingService _loggingService;

        public SearchLoggingFilter(ILoggingService loggingService)
        {
            _loggingService = loggingService;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.ContainsKey("searchTerm"))
            {
                var searchTerm = context.ActionArguments["searchTerm"].ToString();
                var message = $"Search term: {searchTerm}";
                _loggingService.Log(message, "searches.log");
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            // Можно добавить логирование после выполнения действия, если необходимо
        }
    }
}
