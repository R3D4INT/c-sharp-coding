using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac
{
    internal class Program
    {
        static void BubbleSort(int[] array)
        {
            int srav = 0;
            int changes = 0;
            int n = array.Length;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    srav++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        changes++;
                        array[j + 1] = temp;
                        
                    }
                }
            }
            Console.WriteLine($"Srav: {srav}\nChanges: {changes}");
        }

        static void SelectionSort(int[] array)
        {
            int n = array.Length;
            int srav = 0;
            int changes = 0;
            for (int i =0; i < n -1; i++)
            {
                int nmin = i;
                for (int j = i + 1; j < n; j++)
                {
                    srav++;
                    if (array[j] < array[nmin])
                    {
                        nmin = j;
                    }
                }
                changes++;
                int temp  = array[i];
                array[i] = array[nmin];
                array[nmin] = temp;
            }
            Console.WriteLine($"Srav: {srav}\nChanges: {changes}");
        }

        static void InsertionSort(int[] array)
        {
            int n = array.Length;
            int srav = 0;
            int changes = 0;
            for (int i = 1; i < n; i++)
            {
                int c = array[i];
                int j;
                srav++;
                for (j = i - 1; j >= 0 && array[j] > c; j--)
                {
                    
                    changes++;
                    array[j + 1] = array[j];
                    
                }
                changes++;
                array[j + 1] = c;
                
            }
            Console.WriteLine($"Srav: {srav}\nChanges: {changes}");
        }
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 4, 3, 5, 7, 6, 10,9 };
            BubbleSort(array);
            SelectionSort(array);
            InsertionSort(array);

            Console.ReadKey();
        }
    }
}
