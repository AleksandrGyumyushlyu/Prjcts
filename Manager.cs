using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjcts
{
    public class Manager : Employee
    {
        private const double MANAGER_BONUS = 10;
        private string title; // Role in the company

        public Manager(string title, string name, Date employmentDate, double salary) : base(name, employmentDate, salary)
        {
            this.title = title;
        }

        public Manager(string title, string name, Date employmentDate) : base(name, employmentDate)
        {
            this.title = title;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public override double CheckBonus()
        {
            return this.GetSalary() * Manager.MANAGER_BONUS;
        }

        public override string ToString()
        {
            return $"Manager: {this.title}\n{base.ToString()}";
        }

        public static void UnitTest()
        {
            
        }
    }
}
