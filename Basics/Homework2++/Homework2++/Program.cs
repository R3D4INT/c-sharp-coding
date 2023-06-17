using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int number = int.Parse(Console.ReadLine());
            int holder = number;
            int sum = 0;
            while (number > 0)
            {

                sum = sum + number % 10;
                number = number / 10;

            }
            Console.WriteLine($"Сумма цифр числа {holder} равняется:{sum}");

            Console.ReadKey();
        }
    }
}
