using Shop.Services.Interfaces;

namespace Shop.Services.Implementation
{
    public class MonthService : IMonthService
    {
        public string[] GetMonths()
        {
            return new string[]
            {
                "Январь",
                "Февраль",
                "Март",
                "Апрель",
                "Май",
                "Июнь",
                "Июль",
                "Август",
                "Сентябрь",
                "Октябрь",
                "Ноябрь",
                "Декабрь"
            };
        }
    }
}
