﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaxApp.Patterns.Adapter
{
    public interface ILogger
    {
        void LogInfo(string message);
        void LogError(string message);
    }
}
