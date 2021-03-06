﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace UniRx.Diagnostics
{
    public class LogEntry
    {
        // requires
        public string LoggerName { get; private set; }
        public LogType LogType { get; private set; }
        public string Message { get; private set; }
        public DateTime Timestamp { get; private set; }

        // options
        public UnityEngine.Object Context { get; private set; }
        public Exception Exception { get; private set; }
        public string StackTrace { get; private set; }

        public LogEntry(string loggerName, LogType logType, DateTime timestamp, string message, UnityEngine.Object context = null, Exception exception = null, string stackTrace = null)
        {
            this.LoggerName = loggerName;
            this.LogType = logType;
            this.Timestamp = timestamp;
            this.Message = message;
            this.Context = context;
            this.Exception = exception;
            this.StackTrace = stackTrace;
        }

        public override string ToString()
        {
            return "[" + Timestamp.ToString() + "]"
                + "[" + LoggerName + "]"
                + "[" + LogType.ToString() + "]"
                + Message;
        }
    }
}
