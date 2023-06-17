using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8_Abstract_classes_and_Interfaces
{
    abstract class Planet
    {
        public abstract void ReportAboutMovement() ;

        public abstract void ReportAboutLife();
    }

    class Earth : Planet
    {

        public override void ReportAboutMovement()
        {
            Console.WriteLine("The Earth moves around the Sun");
        }

        public override void ReportAboutLife()
        {
            Console.WriteLine("There is life on the Earth");
        }


    }

    class Moon : Planet
    {
        public override void ReportAboutMovement()
        {
            Console.WriteLine("The Moon moves around the Earth");
        }

        public override void ReportAboutLife()
        {
            Console.WriteLine("There is no life on the Moon");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Planet[] mas = new Planet[2];
            mas[0] = new Earth();
            mas[1] = new Moon();

            foreach(Planet f in mas)
            {
                f.ReportAboutMovement();
                f.ReportAboutLife();
                
            }

            Console.ReadKey();
        }
    }
}
