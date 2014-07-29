using Api.Models;
using System.Data;
using System.Data.SqlClient;
using Dapper;
using System.Linq;

namespace Api.Repository
{
    public class UserRepository : IUserRepository
    {
        private IDbConnection _connection;

        public UserRepository(IDbConnection connectionString)
        {
            _connection = connectionString;
        }

        public User Get()
        {
            using (var conn = new SqlConnection(_connection.ConnectionString))
            {
                conn.Open();
                var users =  conn.Query("SELECT top 1  FROM Users");
                return users.First();
            }
        }

    }
}