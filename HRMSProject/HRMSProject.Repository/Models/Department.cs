using System;
using System.Collections.Generic;

namespace HRMSProject.Repository.Models
{
    public partial class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; } = null!;
        public string DeptLocation { get; set; } = null!;
    }
}
