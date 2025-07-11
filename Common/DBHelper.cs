using System;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace HRPayrollSystem.Common
{
    public static class DBHelper
    {
        // 在DBHelper.cs中使用以下连接字符串
        private static readonly string _connectionString =
    "Server=192.168.100.115;Database=project_renshi_db;Uid=teamuser;Pwd=teamuser123456;" +
    "Port=3306;CharSet=utf8mb4;AllowPublicKeyRetrieval=true;SslMode=none";

        public static MySqlConnection GetConnection()
        {
            var conn = new MySqlConnection(_connectionString);
            conn.Open(); // 强制立即测试连接
            return conn;
        }
    }
}