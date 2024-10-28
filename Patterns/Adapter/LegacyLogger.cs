using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Adapter
{
    public class LegacyLogger
    {
        public void LogMessage(string message)
        {
            // Legacy logging implementation
            Console.WriteLine($"[Legacy Logger]: {message}");
        }

        public void LogProblem(string message)
        {
            // Legacy logging implementation
            Console.WriteLine($"[Legacy Logger][problem]: {message}");
        }
    }
}
