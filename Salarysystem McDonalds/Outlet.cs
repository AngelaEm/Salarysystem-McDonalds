using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarysystem_McDonalds
{
    internal class Outlet
    {
        private string OutletLocation;
        private Employee[] EmployeeArray;
        private int CurrentEmployeeCount = 0;

        public Outlet(string outletLocation, int maxEmployees)
        {
            OutletLocation = outletLocation;
            EmployeeArray = new Employee[maxEmployees];
        }

        public void AddEmployee(Employee employee)
        {
            if (CurrentEmployeeCount < EmployeeArray.Length)
            {
                EmployeeArray[CurrentEmployeeCount] = employee;
                CurrentEmployeeCount++;
            }
            else
            {
                Console.WriteLine("Outelt has reached maximum employees.");
            }         
        }

        public void RemoveEmployee(Employee employee)
        {       
                int indexToRemove = Array.IndexOf(EmployeeArray, employee);

                if (indexToRemove != -1 && CurrentEmployeeCount > 0)
                {
                    // New string with removed object
                    Employee[] newArray = new Employee[EmployeeArray.Length - 1];
                    Array.Copy(EmployeeArray, 0, newArray, 0, indexToRemove);
                    Array.Copy(EmployeeArray, indexToRemove + 1, newArray, indexToRemove, EmployeeArray.Length - indexToRemove - 1);

                    // Set EmployeeArray
                    EmployeeArray = newArray;

                    Console.WriteLine("Objektet '" + employee.GetName() + "' har tagits bort från arrayen.");
                }
                else
                {
                    Console.WriteLine("Objektet '" + employee.GetName() + "' hittades inte i arrayen.");
                }


            //Console.WriteLine("Resultat: ");
            //foreach (Employee person in EmployeeArray)
            //{
            //    Console.WriteLine(person.GetName());
            //}

        }

        public void PrintEmployees()
        {
            foreach (Employee person in EmployeeArray)
            {
                if (person != null)
                {
                    Console.WriteLine(person.GetName());
                    Console.WriteLine(person.Role.ToString());

                    Console.WriteLine("***************");
                }
                
            }
        }

    public double GetTotalSalary()
        {
            double total = 0;
            for (int i = 0; i < CurrentEmployeeCount; i++)
            {
                total += EmployeeArray[i].GetMonthlySalary();
            }
            return total;
        }


    

        public string GetOutletLocation()
        {
            return OutletLocation;
        }
    }
}
