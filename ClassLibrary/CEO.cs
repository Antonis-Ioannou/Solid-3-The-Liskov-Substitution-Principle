using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 20M;
            Salary = baseAmount * rank;
        }

        public void GeneratePerformanceReview()
        {
            //Simulate reviewing a direct report
            Console.WriteLine("I'm reviewing a direct report's performance");
        }

        public void FireSomeone()
        {
            //Simulate firing someone
            Console.WriteLine("You're Fired!");
        }
    }
}
