using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee();
            employee1.Name = "Nazani";
            employee1.Surname = "Mustafayeva";
            employee1.Age = 19;
            employee1.DepartmentName = "Code";
            employee1.Salary = 1200;
            Employee employee2= new Employee();
            employee2.Name = "Narmin";
            employee2.Surname = "Nabiyeva";
            employee2.Age = 19;
            employee2.DepartmentName = "Code";
            employee2.Salary = 1800;
            Employee employee3 = new Employee();
            employee3.Name = "Leyla";
            employee3.Surname = "Mustafayeva";
            employee3.Age = 19;
            employee3.DepartmentName = "Code";
            employee3.Salary = 1000;


            Department department = new Department();
            department.AddEmployee(employee1);
            department.AddEmployee(employee2);
            department.AddEmployee(employee3);
           
            Console.WriteLine("--------------------------------------");

            string answer;
            do
            {
                Console.WriteLine("Choose: 1/2/3/0");
                answer = Console.ReadLine();
                if (answer == "1")
                {
                    Console.WriteLine("Enter the employee's name:");
                    string Name = Console.ReadLine();
                    Console.WriteLine("Enter the employee's surname:");
                    string Surname = Console.ReadLine();
                    string Agestr = "";
                    int Age;
                    do
                    {
                        Console.WriteLine("Enter the employee's age:");
                        Agestr = Console.ReadLine();
                    }
                    while (!int.TryParse(Agestr, out Age));
                    Console.WriteLine("Enter the employee's department name:");
                    string DepartmentName = Console.ReadLine();

                    string Salarystr = "";
                    int Salary;
                    do
                    {
                        Console.WriteLine("Enter the employee's salary:");
                        Salarystr = Console.ReadLine();
                    } 
                    while (!int.TryParse(Salarystr, out Salary));

                    Employee employee = new Employee(Name, Surname, Age, DepartmentName, Salary);
                    Department employees = new Department();
                    employees.AddEmployee(employee);
                   

                }
                else if (answer == "2")
                {
                    department.ShowEmployeeInfo();

                }
                else if (answer == "3")
                {
                    department.GetAllEmployeesBySalary();
                }
                else if(answer == "0")
                {
                    break;
                }
            }

            while (answer != "0");
            

        }
    }
}
