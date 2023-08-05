namespace DesignPatterns.Strategy.Models
{
    public class Settings
    {
        public static string ClaimDatabaseType => "DatabaseType";
        public DatabaseType DatabaseType { get; set; }
        public DatabaseType DefaultDatabaseType => DatabaseType.SqlServer;
    }

    public enum DatabaseType
    {
        SqlServer=1,
        MongoDb=2
    }
}
