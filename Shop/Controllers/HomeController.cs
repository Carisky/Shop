using Microsoft.AspNetCore.Mvc;
using Shop.Filters;

namespace Shop.Controllers
{
    [ServiceFilter(typeof(ExceptionLoggingFilter))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
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
