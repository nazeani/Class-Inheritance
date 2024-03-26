using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Department
    {
        Employee[] employees;
        public Department()
        {
            employees = new Employee[0];
        }
        public void  AddEmployee(Employee employee)
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
           
        }
        public Employee[] GetAllEmployees()
        {
            return employees;
        }
        public void ShowEmployeeInfo()
        {
            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{employees[i].Name} " +
                    $"{employees[i].Surname} " +
                    $"{employees[i].Age} " +
                    $"{employees[i].DepartmentName} " +
                    $"{employees[i].Salary} ");
            }
        }
       
        public void GetAllEmployeesBySalary()
        {
            int minSalary=1000;
            int maxSalary=2000;
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i].Salary > minSalary && employees[i].Salary < maxSalary)
                Console.WriteLine($"{employees[i].Name} " +
                    $"{employees[i].Surname} " +
                    $"{employees[i].Age} " +
                    $"{employees[i].DepartmentName} " +
                    $"{employees[i].Salary} ");
            }

        }

    }
}
