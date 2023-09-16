using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarysystem_McDonalds
{
    internal class Employee
    {
        private int EmployeeId;
        private string Name;
        private double MonthlySalary;
        public Role Role;


        public Employee(int id, string name, double salary, Role role)
        {
            EmployeeId = id;
            Name = name;
            SetSalary(salary);
            Role = role;

        }

        public void SetSalary(double salary)
        {
            if (salary >= 0)
            {
                MonthlySalary = salary;
            }
            else
            {
                Console.WriteLine("Invalid salary, try again.");
            }
        }

        public double GiveRaise(double percentage)
        {
            double newSalary = (1 + (percentage / 100)) * MonthlySalary;
            return newSalary;

        }


        public int GetEmployeeId()
        {
            return EmployeeId;
        }

        public string GetName()
        {
            return Name;
        }

        public double GetMonthlySalary()
        {
            return MonthlySalary;
        }

       

        
    }
}
