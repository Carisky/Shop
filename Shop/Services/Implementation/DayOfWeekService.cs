using Shop.Services.Interfaces;

namespace Shop.Services.Implementation
{
    public class DayOfWeekService : IDayOfWeekService
    {
        public string[] GetDaysOfWeek()
        {
            return new string[]
            {
                "Понедельник",
                "Вторник",
                "Среда",
                "Четверг",
                "Пятница",
                "Суббота",
                "Воскресенье"
            };
        }
    }
}
