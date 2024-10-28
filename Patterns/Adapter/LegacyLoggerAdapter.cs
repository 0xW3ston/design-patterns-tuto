using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Adapter
{
    public class LegacyLoggerAdapter : ILogger
    {
        private LegacyLogger _legacyLogger;

        public LegacyLoggerAdapter(LegacyLogger legacyLogger) {
            _legacyLogger = legacyLogger;
        }
        public void LogError(string message)
        {
            _legacyLogger.LogProblem(message);
        }

        public void LogInfo(string message)
        {
            _legacyLogger.LogMessage(message);
        }
    }
}
