using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNET_V7_Logger
{
    public class LoggerManager : ILoggerManager
    {
        private static ILogger logger = LogManager.GetCurrentClassLogger();

        public LoggerManager()
        {

        }
        void ILoggerManager.LogDebug(string message) => logger.Debug(message);
        void ILoggerManager.LogError(string message) => logger.Error(message);
        void ILoggerManager.LogInfo(string message) => logger.Info(message);
        void ILoggerManager.LogWarning(string message) => logger.Warn(message);
    }
}
