using System;
using System.Collections.Generic;

namespace HRMSProject.Repository.Models
{
    public partial class Emp
    {
        public int EmpId { get; set; }
        public string Ename { get; set; } = null!;
        public int Esalary { get; set; }
        public string Eaddress { get; set; } = null!;
    }
}
