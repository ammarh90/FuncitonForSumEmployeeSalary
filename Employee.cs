using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSalary
{
    public class Employee
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }
        public List<Employee> TeamMembers { get; set; }


           public  void SumSalary()
           {
                decimal TotalSalary = 0;

                List<Employee> employees = new List<Employee>()
                {
                     new Employee {Name="Josko Macola", Salary=4000.21M},
                     new Employee {Name="Amit  " ,      Salary=3000.32M},
                     new Employee {Name="Doe" ,         Salary=3000.44M},
                     new Employee {Name="Ram   " ,      Salary=2000.60M},
                     new Employee {Name="Shyam " ,      Salary=7000.41M},
                     new Employee {Name="John Doe" ,    Salary=5000.4M},
    
                };

                TotalSalary = employees.Aggregate<Employee, decimal>(0, (sum, e) => sum += e.Salary);

                Console.WriteLine("Total Salary : " + TotalSalary);
            
        }

    }
}
