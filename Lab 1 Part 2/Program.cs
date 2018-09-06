using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes in first date
            Console.WriteLine("Input date 1");
            DateTime d1 = DateTime.Parse(Console.ReadLine());
            //Takes in second date
            Console.WriteLine("Input date 2");
            DateTime d2 = DateTime.Parse(Console.ReadLine());
            //Calculates difference between dates
            double diff = (d1 - d2).TotalDays;
            //Outputs abs value of difference in the different time scales so dates will work both ways
            Console.WriteLine($"Days: {Math.Abs(diff)}");
            Console.WriteLine($"Hours: {(Math.Abs(diff)) * 24}");
            Console.WriteLine($"Minutes: {((Math.Abs(diff)) * 24) * 60}");

            Console.ReadKey();

        }
    }
}