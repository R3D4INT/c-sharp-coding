using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NotebookPrice, PenPrice, sum, money;
            int NotebookQuantity, PenQuantity;
            Console.WriteLine("Enter the price of the notebook:");
            NotebookPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the price of the pen:");
            PenPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many notebooks does Petro want to buy?");
            NotebookQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many pens does Petro want to buy?");
            PenQuantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How much money does Petro have");
            money = Convert.ToDouble(Console.ReadLine());
            sum = NotebookPrice * NotebookQuantity + PenPrice * PenQuantity;
            double RestOfTheMoney = money - sum;
            if (RestOfTheMoney > 0) 
            {               
                Console.WriteLine($"The rest of the Petro's money is: {RestOfTheMoney}");
            } else {
                Console.WriteLine($"Petro needs more money for this purchase. He need {-RestOfTheMoney} to make a purchase");
            }




            Console.ReadKey();
        }
    }
}
