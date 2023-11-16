using System;

namespace csharp_intermediate_interfaces_dependency_injection
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        /* Dependency Injection: pass dependencies for this class into ctor and assign to private field */
        /* later, we will be initializing a concrete class which implements the interface and pass to ctor in main/program */
        public DbMigrator(ILogger logger)
        {
            this._logger = logger;
        }

        public void Migrate()
        {
            /* Instead of hardcoding what we want to happen, we can utilize different concrete Classes which implement our interface as we create them, */
            /* this adds extensibility for different cases depending on which Class we want to process our data (pass that class to DbMigrator ctor) */
            _logger.LogInfo($"Migration started at {DateTime.Now}");

            // Details of migrating the database

            _logger.LogInfo($"Migration finished at {DateTime.Now}");
        }
    }
}
