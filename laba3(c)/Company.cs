using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace laba3_c_
{
    internal class Company
    {
        public string Title { get; set; }
        public List<Department> Departments { get; } = new List<Department>();
        public void addDepartment(Department department)
        {
            Departments.Add(department);
        }
        public void removeDepartment(Department department)
        {
            Departments.Remove(department);
        }
        public Employee findEmployee(string full_name)
        {
            foreach (var department in Departments)
            {
                foreach(var employee in department.Employees)
                {
                    if ((string)employee.Full_name == full_name)
                    {
                        return employee;
                    }
                }
            }
            return null;
        }
    }
}
