using System;
using System.Collections.Generic;
using VanishingWhist.Infrastructure;
using VanishingWhist.Infrastructure.Logging;

namespace vanishing_whist.app
{
    public class AppSummary : ISummary
    {
        private readonly IDateTimeNow dateTimeNow;
        private readonly ILogger logger;

        private DateTime appStartTime;
        private string appName;
        private string version;
        private string description;
        public DateTime appEndTime;

        public DateTime AppStartTime { get => appStartTime; }
        public string AppName { get => appName; }
        public string Version { get => version; }
        public string Description { get => description; }

        public AppSummary(IDateTimeNow dateTimeNow, ILogger loggers)
        {
            this.dateTimeNow = dateTimeNow;
            this.logger = loggers;
        }
        public void AppStart(string name, string version, string description)
        {
            appStartTime = dateTimeNow.Now;
            appName = name;
            this.version = version;
            this.description = description;

            logger.LogMessage(new Message(Newtonsoft.Json.JsonConvert.SerializeObject(this)));
        }

        public void AddError(ExceptionMessage message)
        {
            throw new NotImplementedException();
        }

        public void AddEvent(Message message)
        {
            throw new NotImplementedException();
        }

        public void AddWarning(Message message)
        {
            throw new NotImplementedException();
        }

        public ExitCode AppComplete()
        {
            throw new NotImplementedException();
        }

    }
}
