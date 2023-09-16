namespace Salarysystem_McDonalds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Employees
            Employee Oliver = new Employee(1, "Oliver", 3000, Role.Janitor);
            Employee Kymia = new Employee(2, "Kymia", 5000, Role.Staff);
            Employee Angela = new Employee(3, "Angela", 10000, Role.Manager);
            Employee Robert = new Employee(4, "Robert", 9000, Role.Staff);
            Employee Felix = new Employee(5, "Felix", 9000, Role.Staff);
            Employee Andreas = new Employee(6, "Andreas", 4000, Role.Janitor);
            Employee Leo = new Employee(7, "Leo", 9000, Role.Manager);
            Employee Tim = new Employee(8, "Tim", 9000, Role.Staff);
            Employee Nea = new Employee(9, "Nea", 9000, Role.Staff);
            Employee Mio = new Employee(10, "Mio", 9000, Role.Staff);
            Employee Åsa = new Employee(11, "Åsa", 4500, Role.Janitor);
            Employee Lisa = new Employee(12, "Lisa", 12000, Role.Manager);
            

            //Outlets
            Outlet frolunda = new Outlet("McDonalds Frölunda", 10);
            Outlet nordstan = new Outlet("McDonalds Nordstan", 5);
            Outlet kungsbacka = new Outlet("McDonalds Kungsbacka", 8);

            //Headoffice
            HeadOffice HeadQuarterInSweden = new HeadOffice(10);

            // Add employees Frölunda
            frolunda.AddEmployee(Oliver);
            frolunda.AddEmployee(Kymia);
            frolunda.AddEmployee(Angela);
            frolunda.AddEmployee(Robert);

            // Add employees Nordstan
            nordstan.AddEmployee(Felix);
            nordstan.AddEmployee(Andreas);
            nordstan.AddEmployee(Leo);
            nordstan.AddEmployee(Tim);       
            
            // Add employees Kungsbacka
            kungsbacka.AddEmployee(Nea);
            kungsbacka.AddEmployee (Mio);
            kungsbacka.AddEmployee(Åsa);
            kungsbacka.AddEmployee(Lisa);

            //Add outlets Sweden
            HeadQuarterInSweden.AddOutlet(nordstan);
            HeadQuarterInSweden.AddOutlet(frolunda);
            HeadQuarterInSweden.AddOutlet (kungsbacka);

            

            // Print total salary
            Console.Write($"Total salary Frölunda: {frolunda.GetTotalSalary()}\n\n");
            Console.Write($"Total salary Nordstan: {nordstan.GetTotalSalary()}\n\n");
            Console.Write($"Total salary Kungsbacka: {kungsbacka.GetTotalSalary()}\n\n");
            Console.Write($"Total salary Sweden: {HeadQuarterInSweden.GetTotalCompanySalary()}\n\n");

            
            // Angela got a raise
            Console.WriteLine($"You get 7% raise {Angela.GetName()} and your new salary is {Angela.GiveRaise(7)}.");

            // Bonus to the company with least total salary.
            Console.WriteLine();
            HeadQuarterInSweden.GiveBonus();
            Console.WriteLine();

            // Print Kungsbackas employees
            kungsbacka.PrintEmployees();
            Console.WriteLine();

            // Remove Lisa from Kunsbacka
            kungsbacka.RemoveEmployee(Lisa);

            // Print Kungsbackas employees
            Console.WriteLine();
            kungsbacka.PrintEmployees();
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}