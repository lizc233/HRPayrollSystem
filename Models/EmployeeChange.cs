using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class EmployeeChange
    {
        public int ChangeID { get; set; }
        public int EmployeeID { get; set; }
        public string ChangeType { get; set; } = string.Empty;
        public string? OldValue { get; set; }
        public string? NewValue { get; set; }
        public DateTime ChangeDate { get; set; }
        public string? Reason { get; set; }
        public int? ApprovedBy { get; set; }
    }
}

