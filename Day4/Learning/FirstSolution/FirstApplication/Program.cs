using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Program
    {
        void PrintName()
        {
            Console.WriteLine("Hi Ester");
        }

        void PrintAnyName(string name)
        {
            Console.WriteLine("Hi "+ name);
        }

        void Greet()
        {
            string name;
            Console.WriteLine("Key in your name : ");
            name = Console.ReadLine();
            Console.WriteLine("Good day " + name);
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello");

            Program p1 = new Program();

            //p1.PrintName();

            //p1.PrintAnyName("Ester");

            //p1.Greet();

            Calculator cal = new Calculator();
            //cal.Add();
            //cal.Product();

            Statements stat = new Statements();
            //stat.UnderstandingSelectionIf();
            //stat.UnderstandingSelectionSwitch();

            //stat.IterationWithFor();
            //stat.IterationWithWhile();
            //stat.IterationWithDoWhile();

           

            Console.ReadKey();

        }
    }

}
