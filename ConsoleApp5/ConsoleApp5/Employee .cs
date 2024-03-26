using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public int Age;
        public string DepartmentName;
        public int Salary;
        public Employee() 
        {
            
        }
        public Employee(string name)
        {
            Name = name;
        }
        public Employee(string name, string surname):this(name)
        {
            Surname = surname;
        }
        public Employee(string name, string surname, int age):this(name,surname)
        {
            Age = age;
        }
        public Employee(string name, string surname, int age, string departmentName):this(name, surname,age)
        {
            DepartmentName = departmentName;
        }
        public Employee(string name, string surname, int age, string departmentName, int salary):this(name, surname, age, departmentName)
        {
            Salary = salary;
        }
    }
}
