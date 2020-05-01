using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VanishingWhist.Infrastructure.Logging;

namespace VanishingWhist.Infrastructure.Tests
{
    [TestClass]
    public class LoggingManagerTests
    {
        private ILogger logger1;
        private ILogger logger2;

        [TestInitialize]
        public void InitializeTest()
        {
            logger1 = new LoggerFake();
            logger2 = new LoggerFake();
        }

        [TestMethod]
        public void LogMessage_given_a_single_registered_logger_logs_message()
        {
            var expected = new Message("Fake message");
            var target = new LoggingManager();
            target.RegisterLogger(logger1);

            target.LogMessage(expected);

            (logger1 as LoggerFake).ActualMessage.Should().BeSameAs(expected);
        }

        [TestMethod]
        public void LogMessage_given_multiple_registered_logger_logs_message_to_each_logger()
        {
            var expected = new Message("Fake message");
            var target = new LoggingManager();
            target.RegisterLogger(logger1);
            target.RegisterLogger(logger2);

            target.LogMessage(expected);

            (logger1 as LoggerFake).ActualMessage.Should().BeSameAs(expected);
            (logger2 as LoggerFake).ActualMessage.Should().BeSameAs(expected);
        }

        [TestMethod]
        public void LogMessage_given_a_single_registered_logger_logs_warning()
        {
            var expected = new Message("Fake message");
            var target = new LoggingManager();
            target.RegisterLogger(logger1);

            target.LogWarning(expected);

            (logger1 as LoggerFake).ActualWarning.Should().BeSameAs(expected);
        }

        [TestMethod]
        public void LogMessage_given_multiple_registered_logger_logs_warning_to_each_logger()
        {
            var expected = new Message("Fake message");
            var target = new LoggingManager();
            target.RegisterLogger(logger1);
            target.RegisterLogger(logger2);

            target.LogWarning(expected);

            (logger1 as LoggerFake).ActualWarning.Should().BeSameAs(expected);
            (logger2 as LoggerFake).ActualWarning.Should().BeSameAs(expected);
        }

        [TestMethod]
        public void LogMessage_given_a_single_registered_logger_logs_error()
        {
            var expected = new ExceptionMessage("Fake message", new System.Exception("Fake Exception"));
            var target = new LoggingManager();
            target.RegisterLogger(logger1);

            target.LogError(expected);

            (logger1 as LoggerFake).ActualException.Should().BeSameAs(expected);
        }

        [TestMethod]
        public void LogMessage_given_multiple_registered_logger_logs_error_to_each_logger()
        {
            var expected = new ExceptionMessage("Fake message", new System.Exception("Fake Exception"));
            var target = new LoggingManager();
            target.RegisterLogger(logger1);
            target.RegisterLogger(logger2);

            target.LogError(expected);

            (logger1 as LoggerFake).ActualException.Should().BeSameAs(expected);
            (logger2 as LoggerFake).ActualException.Should().BeSameAs(expected);
        }
    }

    public class LoggerFake : ILogger
    {
        public Message ActualMessage { get; private set; }
        public Message ActualWarning { get; private set; }
        public ExceptionMessage ActualException{ get; private set; }
        public void LogError(ExceptionMessage message)
        {
            ActualException = message;
        }

        public void LogMessage(Message message)
        {
            ActualMessage = message;
        }

        public void LogWarning(Message message)
        {
            ActualWarning = message;
        }
    }
}
