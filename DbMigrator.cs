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
            Console.WriteLine($"Migration started at {DateTime.Now}");

            // Details of migrating the database

            Console.WriteLine($"Migration finished at {DateTime.Now}");
        }
    }
}
