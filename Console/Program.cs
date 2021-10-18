using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager acountingVP = new Manager();

            acountingVP.FirstName = "Bruce";
            acountingVP.LastName = "Banner";
            acountingVP.CalculatePerHourRate(4);

            Employee emp = new Manager();

            emp.FirstName = "Jack";
            emp.LastName = "Kirby";
            emp.AssignManager(acountingVP);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour. {emp.Manager.FirstName}");

            Console.ReadLine();
        }
    }
}
 