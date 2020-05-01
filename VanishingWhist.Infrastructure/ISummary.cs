using System;
using System.Collections.Generic;
using System.Text;
using VanishingWhist.Infrastructure.Logging;

namespace VanishingWhist.Infrastructure
{
    public interface ISummary
    {
        void AppStart(string name, string version, string description);
        void AddEvent(Message message);
        void AddWarning(Message message);
        void AddError(ExceptionMessage message);
        ExitCode AppComplete();
    }
}
