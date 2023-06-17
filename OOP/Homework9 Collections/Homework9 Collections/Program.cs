using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework9_Collections
{
    class Automobile
    {
        private string name { get; set; }
        private int MaxSpeed { get; set; }

        Automobile(string name, int MaxSpeed) 
        {
            this.name = name;
            this.MaxSpeed = MaxSpeed;
        }

        public static void AboutAutomobile(Automobile car)
        {
            Console.WriteLine($"The name of the car is {car.name}. His max speed is {car.MaxSpeed} k/ph");
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Automobile> list = new List<Automobile>();

                list.Add(new Automobile("BMW", 20));
                list.Add(new Automobile("Audi", 200));
                list.Add(new Automobile("Reno", 150));
                list.Add(new Automobile("Toyota", 170));

                int holder = list[0].MaxSpeed;
                int index = 0;
                foreach (Automobile item in list)
                {
                    if (item.MaxSpeed > holder) 
                    {
                        holder = item.MaxSpeed;
                        index = list.IndexOf(item);
                    }
                    AboutAutomobile(item);

                }

                Console.WriteLine($"The {list[index].name} has max speed. Max speed is {list[index].MaxSpeed} k/ph");

                
                

                Console.ReadKey();
            }
        }
    }
}