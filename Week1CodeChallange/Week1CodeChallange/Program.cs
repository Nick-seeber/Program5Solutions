using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1CodeChallange
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 21; i++)
            {
                Fizzbuzz(i);
            }
            for (int i = 92; i > 78; i--)
            {
                Fizzbuzz(i);
            }
            yodaizer("I like code");
            Console.ReadKey();
        }
        static void Fizzbuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("Fizz Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else
            {
                Console.WriteLine(number);
            }
        }

        static void yodaizer(string text)
        {
            string[] array = text.Split(' ');
            for(int i = array.Count()-1; i >= 0; i--)
            {
                if (array.Count() < 4)
                {
                    Console.WriteLine(array[i]);
                }
                else
                {
                    Console.WriteLine("Not enough words");
                }
                  
                                 
                
            } 
         }

        static string textstats(string input)
        {
            string vowles = "aeiou";
            Console.WriteLine(input.Length);
            Console.WriteLine(input.Count());
            for (int i = 0; i < input.Length; i--)
            {
                return input.char(vowles);
            }
        }
                
        }       
}      

    