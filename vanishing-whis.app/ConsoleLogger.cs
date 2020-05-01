using System;
using VanishingWhist.Infrastructure;

namespace vanishing_whis.app
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
        }

        public void LogMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
