using System;
using System.IO;
using Shop.Services.Interfaces;

namespace Shop.Services.Implementation
{
    public class LoggingService : ILoggingService
    {
        public void Log(string message, string fileName)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), fileName);
            using (var writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
            }
        }
    }
}
