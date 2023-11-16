using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_intermediate_interfaces_dependency_injection
{
    class Program
    {
        static void Main(string[] args)
        {
            /* the DbMigrator Class is extensible, it only expects a Class which implements ILogger, we can pass `new FileLogger` or `new ConsoleLogger` */
            var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\User\\Dev\\fake_log.txt"));

            //var dbMigrator = new DbMigrator(new ConsoleLogger());
            dbMigrator.Migrate();
        }
    }
}
