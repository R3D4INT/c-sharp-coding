using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    internal class Program
    {
        static int NSD_Finder(int FirstNum, int SecondNum, int ThirdNum)
        {
            int NSD = Math.Min(FirstNum, Math.Min(SecondNum, ThirdNum));
            for (; NSD > 1; NSD--)
            {
                if (FirstNum % NSD == 0 && SecondNum % NSD == 0 && ThirdNum % NSD == 0)
                    break;
            }
            return NSD;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            int FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int SecondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int ThirdNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"NSD: {NSD_Finder(FirstNum, SecondNum, ThirdNum)}");
            Console.ReadKey();
        }
    }
}
