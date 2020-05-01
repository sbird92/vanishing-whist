using System;
using System.Collections.Generic;
using System.Text;

namespace VanishingWhist.Infrastructure
{
    public class DateTimeNow : IDateTimeNow
    {
        public DateTime Now => DateTime.Now;
    }
}
