using HRPayrollSystem.Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRPayrollSystem.Models;
using System.Data;
using MySql.Data.MySqlClient;


namespace HRPayrollSystem.DAO
{
    internal class EmployeeDAO
    {
        // 查询所有员工
        public List<Employee> GetAllEmployees()
        {
            // 定义返回的员工列表
            List<Employee> list = new List<Employee>();

            // 查询语句
            string sql = "SELECT * FROM Employees";

            // 使用using确保连接用完自动关闭
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                // 打开数据库连接
                conn.Open();

                // 创建命令对象，执行SQL
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    // 执行读取器，读取返回的结果集
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // 逐行读取数据
                        while (reader.Read())
                        {
                            // 创建Employee对象，逐个赋值
                            Employee emp = new Employee
                            {
                                EmployeeID = reader.GetInt32("EmployeeID"),
                                Name = reader["Name"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                BirthDate = reader["BirthDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["BirthDate"]),
                                IDNumber = reader["IDNumber"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                Email = reader["Email"].ToString(),
                                Address = reader["Address"].ToString(),
                                HireDate = reader["HireDate"] == DBNull.Value ? DateTime.MinValue : Convert.ToDateTime(reader["HireDate"]),
                                DeptID = reader["DeptID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["DeptID"]),
                                PositionID = reader["PositionID"] == DBNull.Value ? 0 : Convert.ToInt32(reader["PositionID"]),
                                Status = reader["Status"].ToString(),
                                Photo = reader["Photo"] == DBNull.Value ? null : (byte[])reader["Photo"]
                            };

                            // 加入到列表中
                            list.Add(emp);
                        }
                    }
                }
            }

            // 返回员工列表
            return list;
        }


        // 添加员工
        public bool AddEmployee(Employee emp)
        {
            string sql = "INSERT INTO Employees (Name, Gender, BirthDate, IDNumber, Phone, Email, Address, HireDate, DeptID, PositionID, Status, Photo) " +
                         "VALUES (@Name, @Gender, @BirthDate, @IDNumber, @Phone, @Email, @Address, @HireDate, @DeptID, @PositionID, @Status, @Photo)";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                cmd.Parameters.AddWithValue("@IDNumber", emp.IDNumber);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Address", emp.Address);
                cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                cmd.Parameters.AddWithValue("@DeptID", emp.DeptID);
                cmd.Parameters.AddWithValue("@PositionID", emp.PositionID);
                cmd.Parameters.AddWithValue("@Status", emp.Status);
                cmd.Parameters.AddWithValue("@Photo", emp.Photo ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 删除员工
        public bool DeleteEmployee(int employeeID)
        {
            string sql = "DELETE FROM Employees WHERE EmployeeID=@EmployeeID";
            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        // 更新员工
        public bool UpdateEmployee(Employee emp)
        {
            string sql = "UPDATE Employees SET Name=@Name, Gender=@Gender, BirthDate=@BirthDate, IDNumber=@IDNumber, " +
                         "Phone=@Phone, Email=@Email, Address=@Address, HireDate=@HireDate, DeptID=@DeptID, " +
                         "PositionID=@PositionID, Status=@Status, Photo=@Photo WHERE EmployeeID=@EmployeeID";

            using (MySqlConnection conn = DBHelper.GetConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@BirthDate", emp.BirthDate);
                cmd.Parameters.AddWithValue("@IDNumber", emp.IDNumber);
                cmd.Parameters.AddWithValue("@Phone", emp.Phone);
                cmd.Parameters.AddWithValue("@Email", emp.Email);
                cmd.Parameters.AddWithValue("@Address", emp.Address);
                cmd.Parameters.AddWithValue("@HireDate", emp.HireDate);
                cmd.Parameters.AddWithValue("@DeptID", emp.DeptID);
                cmd.Parameters.AddWithValue("@PositionID", emp.PositionID);
                cmd.Parameters.AddWithValue("@Status", emp.Status);
                cmd.Parameters.AddWithValue("@Photo", emp.Photo ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@EmployeeID", emp.EmployeeID);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
