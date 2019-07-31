using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
    public class DbMigrate
    {
        private readonly Logger _logger;

        public DbMigrate(Logger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.Log("We're migrating blah blah blah...");
        }
    }
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.Log("We're installing a project...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new Logger();
            var dbMigrate = new DbMigrate(logger);
            var installer = new Installer(logger);

            dbMigrate.Migrate();
            installer.Install();
        }
    }
}
