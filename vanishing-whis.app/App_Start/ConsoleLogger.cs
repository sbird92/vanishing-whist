using System;
using VanishingWhist.Infrastructure;
using VanishingWhist.Infrastructure.Logging;

namespace vanishing_whist.app
{
    public class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        { 
            Console.OutputEncoding = System.Text.Encoding.UTF8; 
        }

        public void LogError(ExceptionMessage message)
        {
            throw new NotImplementedException();
        }

        public void LogMessage(Message message)
        {
            Console.ResetColor();
            Console.WriteLine(message.ToMessageString());
        }

        public void LogWarning(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
