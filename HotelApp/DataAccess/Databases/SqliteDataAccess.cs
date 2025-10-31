using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace HotelAppLibary.Databases
{
    public class SqliteDataAccess : ISqliteDataAccess
    {
        private readonly IConfiguration config;

        public SqliteDataAccess(IConfiguration config)
        {
            this.config = config;
        }

        public List<T> LoadData<T, U>(string sqlStatement,
                                      U parameters,
                                      string connectionStringName)
        {
            string connectionString = config.GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(sqlStatement, parameters).ToList();
                return rows;
            }
        }

        public void SaveData<T>(string sqlStatement,
                                T parameters,
                                string connectionStringName)
        {
            string connectionString = config.GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Execute(sqlStatement, parameters);
            }
        }
    }
}
