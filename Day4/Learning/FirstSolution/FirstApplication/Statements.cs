using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Statements
    {
        public void UnderstandingSelectionIf()
        {
            Console.WriteLine("If statement");

            int num1;
            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            if(num1 == 0)
                Console.WriteLine("it is zero");
            else if(num1 > 100)
                Console.WriteLine("Good");
            else
                Console.WriteLine("I dont know what you say");
        }

        public void UnderstandingSelectionSwitch()
        {
            Console.WriteLine("Switch Case statement");

            int num1;
            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            switch(num1)
            {
                case 0:
                    Console.WriteLine("it is zero");
                    break;
                case 100:
                    Console.WriteLine("Good");
                    break;
                default:
                    Console.WriteLine("I dont know what you say");
                    break;
            }             
              
        }

        public void IterationWithFor()
        {
            Console.WriteLine("For statement");

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void IterationWithWhile()
        {
            Console.WriteLine("While Case statement");

            int i = 0;
            while (i<3)
            {
                Console.WriteLine(i);
                i++;
            } 
        }

        public void IterationWithDoWhile()
        {
            Console.WriteLine("Do while statement");

            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 3);
        }

    }
}
