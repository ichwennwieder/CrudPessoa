using Microsoft.Data.SqlClient;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudPessoa.Repository
{
    public class DbConexao : IDisposable
    {
        private readonly IDbConnection _connection;

        public DbConexao()
        {
            _connection = new SqlConnection("Server=DESKTOP-19KR4PK\\SQLEXPRESS;Database=master;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        public IDbConnection GetConnection()
        {
            if (_connection.State != ConnectionState.Open)
                _connection.Open();

            return _connection;
        }

        public void Dispose()
        {
            _connection?.Dispose();
        }
    }
}
