using System;

namespace Interfaces
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migrate started at {DateTime.Now}");
            _logger.LogInfo($"Migrate finished at {DateTime.Now}");
        }
    }
}
