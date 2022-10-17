using System;
using System.Collections.Generic;

namespace HRMSProject.Repository.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public int DeptId { get; set; }
        public string EmpName { get; set; } = null!;
        public decimal EmpSalary { get; set; }
    }
}
