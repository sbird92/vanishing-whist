using System;
using System.Collections.Generic;
using System.Text;

namespace VanishingWhist.Infrastructure.Logging
{
    public class ExceptionMessage : Message
    {
        private readonly Exception exception;
        public ExceptionMessage(string message, Exception exception) : base(message)
        {
            this.exception = exception;
        }

        public override string ToMessageString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }
}
