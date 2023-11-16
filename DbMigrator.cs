using System;

namespace csharp_intermediate_interfaces_dependency_injection
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        /* Dependency Injection: pass into ctor and assign to private field */
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
