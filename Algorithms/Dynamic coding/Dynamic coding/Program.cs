using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dynamic_coding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the number");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[n];

            if (n > 2)
            {
                mas[0] = 2;
                mas[1] = 3;

                for (int i = 2; i < n; i++)
                {
                    mas[i] = mas[i - 1] + mas[i - 2];
                }

                Console.WriteLine($"The number of variations is {mas[n - 1]}");
            }
            else if (n == 2)
            {
                Console.WriteLine($"The number of variations is 3");
            }
            else if (n == 1)
            {
                Console.WriteLine($"The number of variations is 2");
            } else
            {
                throw new Exception("The length of the number must be more than 0");
            }

            Console.ReadKey();


        }
    }
}
