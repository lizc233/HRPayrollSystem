using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPayrollSystem.Common;

using System.Configuration;

namespace HRPayrollSystem.DAL
{
    public static class DatabaseTest
    {
        public static string TestConnection()
        {

            try
            {
                using (var conn = DBHelper.GetConnection())
                {
                    return $"连接成功！服务器版本：{conn.ServerVersion}";
                }
            }
            catch (Exception ex)
            {
                return $"连接失败：{ex.Message}";
            }

        }
    }
}
