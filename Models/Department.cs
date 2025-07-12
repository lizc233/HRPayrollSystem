using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int? ManagerID { get; set; }
    }
}

