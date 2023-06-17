using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efecPrac
{
    internal class Program
    {
        static int FindOpor(int[] array, int MinIndex, int MaxIndex)
        {
            int opor = MinIndex - 1;
            int temp = 0;
            for (int i = MinIndex; i < MaxIndex; i++)
            {
                if (array[i] < array[MaxIndex])
                {
                    opor++;
                    temp = array[opor];
                    array[opor] = array[i];
                    array[i] = temp;
                }
            }
            opor++;
            temp = array[opor];
            array[opor] = array[MaxIndex];
            array[MaxIndex] = temp;

            return opor;
        }

        static int[] QuickSort(int[] array, int MinIndex, int MaxIndex)
        {
            if (MinIndex >= MaxIndex)
            {
                return array;
            }
            int pivot = FindOpor(array, MinIndex, MaxIndex);
            QuickSort(array, MinIndex, pivot - 1);
            QuickSort(array, pivot + 1, MaxIndex);

            return array;
        }

        static void Swap(ref int FirstElement, ref int SecondElement)
        {
            int temp = FirstElement;
            FirstElement = SecondElement;
            SecondElement = temp;
        }

        static int[] ShellSort(int[] array)
        {
            
            int step = array.Length / 2;
            while (step >= 1)
            {
                for (int i = step; i < array.Length; i++)
                {
                    int j = i;
                    while ((j >= step) && (array[j - step] > array[j]))
                    {
                        Swap(ref array[j], ref array[j - step]);
                        j = j - step;
                    }
                }

                step /= 2;
            }

            return array;
        }
        static void Main(string[] args)
        {
            int[] array = { 30, 5, 15, 6, 25, 21, 29, 2, 9, 20, 14, 12, 13, 24, 3 };
            //array = QuickSort(array, 0, array.Length - 1);
            array = ShellSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
