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
            /* StreamWriter comes from System.IO and will create a new file if not already exists (2nd arg: true == append, false == overwrite) */
            var streamWriter = new StreamWriter(this._path, true);
        }

        public void LogInfo(string message)
        {
            throw new System.NotImplementedException();
        }
    }
}
