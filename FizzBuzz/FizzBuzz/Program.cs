using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            fizzBuzz(1);
            Console.ReadKey();
        }
        static void fizzBuzz(int num1)
        {
            for (int i = num1; num1 < 31; num1++) 
            {
                if (num1 % 3 == 0 && num1 % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num1 % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (num1 % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(num1);
                }

            }
        }

    }
}
