using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Homework4_
{
    internal class Program
    {
        static int MaxElement(int[] array)
        {
            int holder = array[0];
            foreach(int el in array)
            {
                if(holder < el)
                {
                    holder = el;
                }
            }
            return holder;
            
        }
        static void Main(string[] args)
        {           
            Console.WriteLine("Enter the length of array");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[length];
            Random rnd = new Random();
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-50, 50);
                Console.WriteLine(mas[i]);
            }

            int max = MaxElement(mas);
            Console.WriteLine($"Max element of the array is: {max}");

            Console.ReadKey();

        }
    }
}
