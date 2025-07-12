using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRPayrollSystem.Models
{
    public class SalaryRecord
    {
        public int RecordID { get; set; }
        public int EmployeeID { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Bonus { get; set; }
        public decimal Deduction { get; set; }
        public decimal Tax { get; set; }
        public decimal NetSalary { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string Status { get; set; } = "Pending";
    }
}
