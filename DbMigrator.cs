using System;

namespace csharp_intermediate_interfaces_dependency_injection
{
    public class DbMigrator
    {
        public void Migrate()
        {
            Console.WriteLine($"Migration started at {DateTime.Now}");

            // Details of migrating the database

            Console.WriteLine($"Migration finished at {DateTime.Now}");
        }
    }
}
