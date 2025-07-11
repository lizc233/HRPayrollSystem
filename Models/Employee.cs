using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class Employee
    {


        public int EmployeeID { get; set; }       // 主键
        public string Name { get; set; }          // 姓名
        public string Gender { get; set; }        // 性别
        public DateTime BirthDate { get; set; }   // 出生日期
        public string IDNumber { get; set; }      // 身份证号
        public string Phone { get; set; }         // 电话
        public string Email { get; set; }         // 邮箱
        public string Address { get; set; }       // 地址
        public DateTime HireDate { get; set; }    // 入职日期
        public int DeptID { get; set; }           // 部门ID
        public int PositionID { get; set; }       // 岗位ID
        public string Status { get; set; }        // 状态
        public byte[] Photo { get; set; }         // 照片（字节数组）
    }
}
