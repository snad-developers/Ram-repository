using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Models
{
  public class EmployeeVM
    {
        public int EmpId { get; set; }
        public int DeptId { get; set; }
        public string EmpName { get; set; } = null!;
        public decimal EmpSalary { get; set; }

    }
}
