
Database mssql = Database.GetInstance("mssqlConnection");
Console.WriteLine($"mssql Count = {mssql.Count}");
Database mysql = Database.GetInstance("mysqlConnection");
Console.WriteLine($"mysql Count = {mysql.Count}");
Database oracle = Database.GetInstance("oracleConnection");
Console.WriteLine($"oracle Count = {oracle.Count}");

Console.WriteLine($"mssql Count = {mssql.Count}");
Console.WriteLine($"mssql Count = {mssql.Count}");

Database mssql1 = Database.GetInstance("mssqlConnection");
Console.WriteLine($"mssql1 Count = {mssql1.Count}");
Console.WriteLine($"mssql1 Count = {mssql1.Count}");
Database mysql1 = Database.GetInstance("mysqlConnection");
Console.WriteLine($"mysql1 Count = {mysql1.Count}");
Database oracle1 = Database.GetInstance("oracleConnection");
Console.WriteLine($"oracle1 Count = {oracle1.Count}");

class Database
{
    Database(string key)
    {
        Console.WriteLine($"{nameof(Database)} nesnesi {key} ile  oluşturuldu");
    }
    static Dictionary<string, Database> _databases = new();

    public static Database GetInstance(string key)
    {
        if (!_databases.ContainsKey(key))
            _databases.Add(key, new Database(key));
        return _databases[key];
    }
    int count = 0;
    public int Count => ++count;
}