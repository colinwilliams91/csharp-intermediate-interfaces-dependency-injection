using System;
using System.IO;
using csharp_intermediate_interfaces_dependency_injection.Enums;
using csharp_intermediate_interfaces_dependency_injection.Interfaces;

namespace csharp_intermediate_interfaces_dependency_injection
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            this._path = path;
        }

        public void LogError(string message)
        {
            Log(message, LogLevel.Error);
        }

        public void LogInfo(string message)
        {
            Log(message, LogLevel.Info);
        }

        private void Log(string message, LogLevel logLevel)
        {
            /* StreamWriter comes from System.IO and will create a new file if not already exists (2nd arg: true == append, false == overwrite) */
            using (var streamWriter = new StreamWriter(this._path, true))
            {
                string logType = GetLogTypeString(logLevel);
                /* StreamWriter uses a "file resource" not managed by CLR, so we need to dispose of it manually */
                streamWriter.WriteLine(logType + ": " + message);
                /* streamWriter.Dispose(); <<-- disposes of external resources not managed by CLR AUTOMATICALLY with `using` statement */
            }
        }

        /* using Enum to avoid magic strings and make modular/dynamic Log method */
        private string GetLogTypeString(LogLevel logLevel)
        {
            switch (logLevel)
            {
                case LogLevel.Info:
                    return "INFO";
                case LogLevel.Error:
                    return "ERROR";
                default:
                    throw new ArgumentOutOfRangeException(nameof(logLevel), logLevel, null);
            }
        }
    }
}
