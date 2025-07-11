using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HRPayrollSystem.Models;


namespace HRPayrollSystem.BLL
{
    internal class EmployeeService
    {
        
        //测试1
            public static bool ValidateEmployee(Employee emp, out string errorMsg)
            {
                if (string.IsNullOrWhiteSpace(emp.Name))
                {
                    errorMsg = "姓名不能为空！";
                    return false;
                }
                if (string.IsNullOrWhiteSpace(emp.Phone) || !Regex.IsMatch(emp.Phone, @"^\d{11}$"))
                {
                    errorMsg = "手机号码格式不正确！";
                    return false;
                }
                // 更多验证...
                errorMsg = "";
                return true;
            }
        
    }
}
