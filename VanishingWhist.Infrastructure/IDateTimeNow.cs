using System;
using System.Collections.Generic;
using System.Text;

namespace VanishingWhist.Infrastructure
{
    public interface IDateTimeNow
    {
        DateTime Now { get; }
    }
}
