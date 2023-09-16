using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salarysystem_McDonalds
{
    internal class HeadOffice
    {
        private Outlet[] ArrayWithOutlets;
        private int CurrentOutletCount = 0;

        public HeadOffice(int maxOutlet)
        {
            ArrayWithOutlets = new Outlet[maxOutlet];
        }

        public void AddOutlet(Outlet outlet)
        {
            if (CurrentOutletCount < ArrayWithOutlets.Length)
            {
                ArrayWithOutlets[CurrentOutletCount] = outlet;
                CurrentOutletCount++;
            }
            else
            {
                Console.WriteLine("HeadOffice has reached maximun outlets.");
            }
        }

        public double GetTotalCompanySalary()
        {
            double total = 0;

            for (int i = 0; i < CurrentOutletCount; i++)
            {
                total += ArrayWithOutlets[i].GetTotalSalary();
            }
            return total;
        }
        public void GiveBonus()
        {
            double leastSalary = 0;
            string name = "";

            for (int i = 0; i < CurrentOutletCount; i++)
            {
                leastSalary = ArrayWithOutlets[i].GetTotalSalary();
                name = ArrayWithOutlets[i].GetOutletLocation();

                for (int j = 1; j < CurrentOutletCount; j++)
                {
                    if (leastSalary > ArrayWithOutlets[j].GetTotalSalary()) ;
                    {
                        leastSalary = ArrayWithOutlets[j].GetTotalSalary();
                        name = ArrayWithOutlets[j].GetOutletLocation();
                    }
                }               
            }

            double totalBonus = leastSalary * 0.2;

            Console.WriteLine($"{name} has the least salary {leastSalary} so they will get a bonus of {totalBonus} dollar to share.");
         
        }
    }
}
