using Microsoft.AspNetCore.Mvc;
using Shop.Filters;
using Shop.Services.Implementation;
using Shop.Services.Interfaces;

namespace Shop.Controllers
{
    [ServiceFilter(typeof(ExceptionLoggingFilter))]
    public class HomeController : Controller
    {
        private readonly ISmartPhraseGenerator _smartPhraseGenerator;
        private readonly IDayOfWeekService _dayOfWeekService;
        private readonly IMonthService _monthService;

        public HomeController(
            ISmartPhraseGenerator smartPhraseGenerator,
            IDayOfWeekService dayOfWeekService,
            IMonthService monthService
        )
        {
            _smartPhraseGenerator = smartPhraseGenerator;
            _dayOfWeekService = dayOfWeekService;
            _monthService = monthService;
        }

        public IActionResult Index()
        {
            ViewBag.SmartPhrase = _smartPhraseGenerator.GetSmartPhrase();

            var daysOfWeek = _dayOfWeekService.GetDaysOfWeek();
            var months = _monthService.GetMonths();

            ViewData["DaysOfWeek"] = daysOfWeek;
            ViewData["Months"] = months;

            return View();
        }

        public IActionResult About()
        {
            ViewBag.SmartPhrase = _smartPhraseGenerator.GetSmartPhrase();
            return View();
        }

        [ServiceFilter(typeof(SearchLoggingFilter))]
        public IActionResult Search(string searchTerm)
        {
            // Реализация поиска товаров
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
