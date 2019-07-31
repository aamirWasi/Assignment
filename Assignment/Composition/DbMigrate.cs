namespace Composition
{
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
}
