using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Text;

namespace DapperDAL
{
    public class DbConnectionFactory : IDbConnectionFactory
    {
        private IDbConnection dbConnection;

        public IDbConnection GetConnection()
        {
            if (dbConnection == null)
            {
                dbConnection = new MySql.Data.MySqlClient.MySqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);
            }
            return dbConnection;
        }
    }
}
