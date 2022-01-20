using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    class FirstExercise
    {
        //q1
        public void PrintAllNum()
        {
            int num1;

            Console.WriteLine("Give a number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: ");
            for (int i = 0; i <= num1; i++)
            {
                Console.WriteLine(i);
            }
        }

        //q2
        public void DetermineOddOrEven()
        {
            int num1;

            Console.WriteLine("Give a number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: ");
            if (num1 % 2 == 0)
            {
                Console.WriteLine(num1 + " is an even number");
            }
            else
                Console.WriteLine(num1 + " is an odd number");

        }

        //q3
        public void FindGreaterNum()
        {
            int num1, num2;

            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Result: ");

            if (num1 > num2)
                Console.WriteLine("The greater number is " + num1);
            else
                Console.WriteLine("The greater number is " + num2);
        }

        //q4
        public void FindGreatestNum()
        {
            int num1, num2, num3, greatest;

            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the third number : ");
            num3 = Convert.ToInt32(Console.ReadLine());

            greatest = num1;

            if (greatest < num2 && num2 > num3)
                greatest = num2;

            else if (greatest < num3 && num3 > num2)
                greatest = num3;

            Console.WriteLine("Result: ");
            Console.WriteLine("The greater number is " + greatest);
        }


        //q5
        public void FindInBetweenNum()
        {
            int num1, num2;

            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: ");

            for (int i = num1 + 1; i < num2; i++)
            {
                Console.WriteLine(i);
            }

        }

        //q6
        public void FindIsPrime()
        {
            int num1;
            bool isPrime = true;

            Console.WriteLine("Please enter a number : ");
            num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 <=1)
            {
                isPrime = false;
            }

            for (int i = 2; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            Console.WriteLine("Result: ");

            if (isPrime)
                Console.WriteLine(num1 + " is a prime number");
            else
                Console.WriteLine(num1 + " is not a prime number");
        }

        //q7
        public void FindAllPrime()
        {
            int num1, num2, count = 0;
            bool isPrime = true;

            Console.WriteLine("Please enter the first number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            
            int[] numbers = new int[num2 - num1];
            for (int i = num1 + 1; i < num2; i++)
            {
                numbers[count] = i;
                count++;
            }

            for (int i = 0; i < count; i++)
            {
                if (numbers[i] <= 1)
                {
                    isPrime = false;
                }

                for (int x = 2; x < numbers[i]; x++)
                {
                    if (numbers[i] % x == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                Console.WriteLine("Result: ");

                if (isPrime)
                    Console.WriteLine(numbers[i] + " is a prime number");
                else
                    Console.WriteLine(numbers[i] + " is not a prime number");
            }
        }

        //q8
        public void FindSumDivisibleNum()
        {
            List<int> numbers = new List<int>();
            int num, sum = 0;

            do
            {
                Console.WriteLine("Please enter a number : ");
                num = Convert.ToInt32(Console.ReadLine());
                if (num >= 0)
                    numbers.Add(num);
            } while (num >= 0);

            foreach (int x in numbers)
            {
                if (x % 7 == 0)
                {
                    sum += x;
                }
            }

            Console.WriteLine("Result: ");
            Console.WriteLine("Total of numbers divisible by 7 is :" + sum);
        }

        //q9
        public void FindSumOfAllDigit()
        {
            string nums;
            int sum = 0;

            Console.WriteLine("Please enter a number with 4 digits: ");
            nums = Console.ReadLine();

            int[] numbers = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = int.Parse(nums[i].ToString());
                sum += numbers[i];
            }

            Console.WriteLine("Result: ");
            Console.WriteLine("Total of all digits are :" + sum);

        }

        //q10
        public void FindIsPalindrome()
        {
            Console.WriteLine("Please enter a number with 4 digits: ");
            string oriString = Console.ReadLine();

            char[] charArray = oriString.ToArray();
            Array.Reverse(charArray);
            string newString = new string(charArray);

            Console.WriteLine("Result: ");

            Console.WriteLine("Reverse String : " + newString);
            if (oriString.Equals(newString))
            {
                Console.WriteLine(oriString + " is Palindrome.");
            }
            else
                Console.WriteLine(oriString + " is not Palindrome.");

        }

    }
}
