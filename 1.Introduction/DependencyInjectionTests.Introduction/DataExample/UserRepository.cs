﻿using Dapper;

namespace DependencyInjectionTests.Introduction.DataExample;

public class UserRepository : IUserRepository
{
    private readonly IDbConnectionFactory _dbConnectionFactory;

    public UserRepository(IDbConnectionFactory dbConnectionFactory)
    {
        _dbConnectionFactory = dbConnectionFactory;
    }

    public async Task<IEnumerable<User>> GetAllAsync()
    {
        using var connection = await _dbConnectionFactory.CreateDbConnectionAsync();
        return await connection.QueryAsync<User>("select * from Users");
    }

    public async Task<User?> GetByIdAsync(Guid id)
    {
        const string query = "select * from Users where Id = @Id";
        using var connection = await _dbConnectionFactory.CreateDbConnectionAsync();
        return await connection.QuerySingleOrDefaultAsync<User>(query, new { Id = id });
    }

    public async Task<bool> CreateAsync(User user)
    {
        const string query = "INSERT INTO Users (Id, FullName) VALUES (@Id, @FullName)";
        using var connection = await _dbConnectionFactory.CreateDbConnectionAsync();
        var result = await connection.ExecuteAsync(query,
            new { user.Id, user.FullName });
        return result > 0;
    }

    public async Task<bool> DeleteByIdAsync(Guid id)
    {
        const string query = "DELETE FROM Users where Id = @Id";
        using var connection = await _dbConnectionFactory.CreateDbConnectionAsync();
        var result = await connection.ExecuteAsync(query, new { Id = id });
        return result > 0;
    }
}