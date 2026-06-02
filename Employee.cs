using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public class Employee
    {
        private const double DEFAULT_SALARY = 4500;
        private const double EMPLOYEE_BONUS = 1.7;
        private string name;
        private Date employmentDate;
        private double salary;

        public Employee(string name, Date employmentDate, double salary)
        {
            this.name = name;
            this.employmentDate = employmentDate;
            this.salary = salary;
        }

        public Employee(string name, Date employmentDate) : this(name, employmentDate, Employee.DEFAULT_SALARY) { }

        public string GetName()
        {
            return this.name;
        }

        public Date GetEmploymentDate()
        {
            return new Date(this.employmentDate);
        }

        public double GetSalary()
        {
            return this.salary;
        }

        public bool SetSalary(double newSalary)
        {
            if (newSalary >= 0)
            {
                this.salary = newSalary;
                return true;
            }
            return false;
        }

        public virtual double CheckBonus()
        {
            return salary * Employee.EMPLOYEE_BONUS;
        }

        public override string ToString()
        {
            return $"Name: {this.name}\nEmployee since: {this.employmentDate}\nMonthly Salary: {this.salary}\nBonus: {this.CheckBonus()}\n";
        }

        public static void UnitTest()
        {
            double newSalary;

            Employee emp = new Employee("Ovadia Isakov", new Date());
            Console.WriteLine(emp);

            newSalary = -5;
            Console.WriteLine(emp.SetSalary(newSalary) ? $"Set new salary to {newSalary}" : "Failed to update the salary");
            Console.WriteLine(emp);
            newSalary = 5000;
            Console.WriteLine(emp.SetSalary(newSalary) ? $"Set new salary to {newSalary}" : "Failed to update the salary");
            Console.WriteLine(emp);
        }
    }
}
