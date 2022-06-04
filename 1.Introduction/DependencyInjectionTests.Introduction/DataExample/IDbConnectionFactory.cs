using System.Data;

namespace DependencyInjectionTests.Introduction.DataExample;

public interface IDbConnectionFactory
{
    Task<IDbConnection> CreateDbConnectionAsync();
}