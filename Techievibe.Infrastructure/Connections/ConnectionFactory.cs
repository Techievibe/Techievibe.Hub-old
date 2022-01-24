using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Techievibe.Infrastructure.Connections
{
    public static class ConnectionFactory
    {
        private static IConfiguration _configuration;

        public static SqlConnection GetConnection()
        {
            if (Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") == "Development")
            {
                return GetConnection(_configuration.GetConnectionString("LocalSqlAuthentication"));
            }
            return GetConnection(_configuration.GetConnectionString("LocalSqlAuthentication"));
        }

        public static SqlConnection GetConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
    }
}
