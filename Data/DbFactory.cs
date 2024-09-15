using MySql.Data.MySqlClient;
using System.Data;

namespace StocksApi.Data;

public class DbFactory : IDbFactory
{
    private readonly IConfiguration _configuration;

    public DbFactory(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public IDbConnection CreateConnection()
    {
        return new MySqlConnection(_configuration.GetConnectionString("DefaultConnection"));
    }
}
