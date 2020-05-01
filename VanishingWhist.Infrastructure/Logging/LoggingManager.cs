using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VanishingWhist.Infrastructure.Logging
{
    public class LoggingManager : ILogger
    {
        private readonly List<ILogger> loggers;

        public LoggingManager()
        {
            loggers = new List<ILogger>();
        }

        public void RegisterLogger(ILogger logger)
        {
            loggers.Add(logger);
        }

        public void LogError(ExceptionMessage message)
        {
            foreach (var logger in loggers)
            {
                logger.LogError(message);
            }
        }

        public void LogMessage(Message message)
        {
            foreach (var logger in loggers)
            {
                logger.LogMessage(message);
            }
        }

        public void LogWarning(Message message)
        {
            foreach (var logger in loggers)
            {
                logger.LogWarning(message);
            }
        }
    }
}
