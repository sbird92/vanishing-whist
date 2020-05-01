using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace VanishingWhist.Infrastructure.Logging
{
    public enum LogLevel
    {
        Info,
        Warn,
        Error
    }

    public class Message
    {
        public string LogMessage { get; private set; }
        public IDictionary<string, string> Data { get; private set; }

        public Message(string message)
        {
            LogMessage = message;
        }

        public Message(string message, IDictionary<string, string> data)
        {
            LogMessage = message;
            Data = data;
        }

        public virtual string ToMessageString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}
