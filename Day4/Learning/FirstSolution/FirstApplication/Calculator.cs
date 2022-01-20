using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class Calculator
    {
        int num1, num2,  sum;

        void Details()
        {
            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num1 + num2;
        }

        public void Add()
        {
            Details();

            Console.WriteLine("Sum of " + num1 + " and " + num2 + " = " + sum);

        }

        public void Product()
        {
            Details();

            Console.WriteLine("Sum of Product" + num1 + " and " + num2 + " = " + sum);

        }
    }
}
