using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть розмiр масиву");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[length];

            Random random = new Random();
            Console.WriteLine("Масив:");
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(-5000, 5000);
                Console.WriteLine(mas[i]);
            }

            int SumPositiveNumbers = 0;
            int QuantityOfPairNumbers = 0;

            for (int i = 0; i < mas.Length; i++)
            {
               if (mas[i] > 0)
               {
                   SumPositiveNumbers += mas[i];
               }

                if (mas[i] % 2 == 0)
                {
                    QuantityOfPairNumbers++;
                }
              
            }
            Console.WriteLine($"Сумма додатнiх елементiв масиву: {SumPositiveNumbers} \nКiлькiсть парних елементiв масиву: {QuantityOfPairNumbers}");

            Console.ReadKey();
        }
    }
}
