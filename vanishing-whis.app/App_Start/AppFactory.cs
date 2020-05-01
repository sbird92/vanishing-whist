using System;
using System.Collections.Generic;
using System.Text;
using VanishingWhist.Infrastructure;
using VanishingWhist.Infrastructure.Logging;

namespace vanishing_whist.app
{
    public class AppFactory
    {
        static readonly AppFactory singleton;
        static AppFactory()
        {
            singleton = new AppFactory
            {
                AppSummary = BuildAppSummary()
            };
        }

        public AppSummary AppSummary { get; private set; }

        public static AppFactory GetAppFactory()
        {
            return singleton;
        }

        private static AppSummary BuildAppSummary()
        {
            var dateTimeprovider = new DateTimeNow();
            var logger = BuildLogger();
            var summary = new AppSummary(dateTimeprovider, logger);

            return summary;
        }

        private static ILogger BuildLogger()
        {
            LoggingManager logManager = new LoggingManager();
            logManager.RegisterLogger(GetConsoleLogger());
            return logManager;
        }

        private static ILogger GetConsoleLogger()
        {
            return new ConsoleLogger();
        }

    }
}
