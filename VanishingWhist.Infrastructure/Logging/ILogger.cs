
using System.Threading.Tasks;

namespace VanishingWhist.Infrastructure.Logging
{
    public interface ILogger
    {
        void LogMessage(Message message);
        void LogWarning(Message message);
        void LogError(ExceptionMessage message);
    }
}
