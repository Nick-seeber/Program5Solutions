using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Day2Homeworkagain
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Nick";
            int myAge = 28;
            bool myBool = true;
            List<string>productsList = new List<string>(){"basketball", "baseball glove","tennis shoes","hockey puck"};
            Console.WriteLine("My name is " + myName + " and I'm a beast of a programmer");
            Console.WriteLine("I am " + myAge + " years awesome");
            Console.WriteLine("I set my boolean value equal to " + myBool);
            for (int i = 0; i < productsList.Count; i = i + 1)
            {
                Console.WriteLine(productsList[i]);
            }
            forLoops();
            whileLoops();

            Console.ReadKey();
            
           
        }
        static void forLoops()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            for (int i = 10; i < 30; i = i + 2)
            {
                Console.WriteLine(i);
            }
            for (int i = 100; i > 70; i = i - 5)
            {
                Console.WriteLine(i);
            }

        }

        static void whileLoops()
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            i = 10;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }

            i = 10;
            while (i < 30)
            {

            }
        }
    
    
    }

}
