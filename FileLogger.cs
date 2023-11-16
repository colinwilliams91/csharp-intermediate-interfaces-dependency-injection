using System.IO;

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
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            /* StreamWriter comes from System.IO and will create a new file if not already exists (2nd arg: true == append, false == overwrite) */
            using (var streamWriter = new StreamWriter(this._path, true))
            {
                /* StreamWriter uses a "file resource" not managed by CLR, so we need to dispose of it manually */
                streamWriter.WriteLine(messageType + ": " + message);
                /* streamWriter.Dispose(); <<-- disposes of external resources not managed by CLR AUTOMATICALLY with `using` statement */
            }
        }
    }
}
