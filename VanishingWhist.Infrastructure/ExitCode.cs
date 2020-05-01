using System;
using System.Collections.Generic;
using System.Text;

namespace VanishingWhist.Infrastructure
{
    public enum ExitCode : int
    {
        Success = 0,
        WithWarnings = 1,
        WithErrors = 2
    }
}
