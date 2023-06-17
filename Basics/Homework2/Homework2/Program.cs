using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            while (FirstNumber <= SecondNumber)
            {
                Console.WriteLine("Ошибка ввода. Первое число должно быть больше чем второе");
                Console.WriteLine("Введите первое число");
                 FirstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите второе число");
                 SecondNumber = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("");
            for (int i = FirstNumber; i >= SecondNumber; i--)
            {
                Console.WriteLine("{0}", i);               
            }



            Console.ReadKey();
        }
    }
}
