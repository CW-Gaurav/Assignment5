using System.Data;

namespace StocksApi.Data;

public interface IDbFactory
{
    IDbConnection CreateConnection();
}
