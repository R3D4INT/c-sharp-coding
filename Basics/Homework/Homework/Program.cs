using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NotebookPrice, PenPrice, sum;
            int NotebookQuantity, PenQuantity;
            Console.WriteLine("Enter the price of the notebook:");
            NotebookPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the price of the pen:");
            PenPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many notebooks does Petro want to buy?");
            NotebookQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pens does Petro want to buy?");
            PenQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Total price is: {0}",sum = NotebookPrice * NotebookQuantity + PenPrice * PenQuantity);


            Console.ReadKey();


        }
    }
}
