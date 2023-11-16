using System;

namespace csharp_intermediate_interfaces_dependency_injection
{
    public class ConsoleLogger : ILogger
    {
        public void LogError(string message)
        {
            throw new NotImplementedException();
        }

        public void LogInfo(string message)
        {
            throw new NotImplementedException();
        }
    }
}
