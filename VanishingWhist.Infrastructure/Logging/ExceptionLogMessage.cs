using System;
using System.Collections.Generic;
using System.Text;

namespace VanishingWhist.Infrastructure.Logging
{
    public class ExceptionMessage : Message
    {
        public Exception LogException { get; private set; }
        public ExceptionMessage(string message, Exception exception) : base(message)
        {
            LogException = exception;
        }

        public override string ToMessageString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
