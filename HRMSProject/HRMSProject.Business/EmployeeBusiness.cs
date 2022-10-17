using HRMSProject.Business.Interfaces;
using HRMSProject.Models;
using HRMSProject.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Business
{

    public class EmployeeBusiness : IEmployeeBusiness
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeBusiness(IEmployeeRepository empRepository)
        {
            _employeeRepository = empRepository;
        }

        public List<EmployeeVM> GetAllEmployees()

        {
            var employees = _employeeRepository.GetAllEmployees();
            List<EmployeeVM> emps = new List<EmployeeVM>();
            foreach (var emp in employees)
            {
                EmployeeVM vm = new EmployeeVM()
                {
                    DeptId = emp.DeptId,
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpSalary = emp.EmpSalary

                };
                emps.Add(vm);

            }
            return emps;

        }
    }
}

