namespace ApiCapacitacion
{
  public class PostgreSqlConfiguration
  {
    private readonly string _connectionString;   

    public PostgreSqlConfiguration(string connectionString)
    {
      _connectionString = connectionString;
    }

    public string GetConnectionString()
    {
      return _connectionString;
    }
  }
}
