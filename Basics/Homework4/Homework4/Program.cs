using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Program
    {
        static void Average (double x, double y)
        {
            double average = (x + y) / 2;
            Console.WriteLine($"Average of nums {x} and {y} = {average}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first num");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second num");
            int b = Convert.ToInt32(Console.ReadLine());
            Average(a, b);

            Console.ReadKey();
        }
    }
}
