using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1_pratice
{
    class Program
    {
        static void Main(string[] args)

        {
            //1.Declare a string variable called "myName" and set it equal to your name
            string myName = "Nick";
            //Declare a number varible called "myAge" and set it equal to your age
            int myAge = 28;
            //Declare a boolean value called "myBool" and set it equal to true
            bool myBool = true;
            //Declare a new list of strings called "productsList" and set it equal to "basketball", "Baseball glove", "tennis shoes", "hockey Puck"
            List<string> productsList = new List<string>() { "Basketball", "Baseball glove", "tennis shoes", "hockey puck" };
            //Printing variables to the console using console.writeline()
            //Print your name to the console using the format: my name is <myName> and I am a best of a programmer
            Console.WriteLine("My name is " + myName + " I am a beast of a programmer!");
            //Print out your age to the console using the format: "I am <myAge> years awesome!"
            Console.WriteLine("I am " + myAge + " years awesome!");
            //pring out your boolean value using the format: "I set my bookean value equal to  <myBool>
            Console.WriteLine("I set my Boolean Value equal to: " + myBool);
            //Using a for loop print out each value in productsList
            for (int i = 0; i < productsList.Count; i = i + 1)
            {
                Console.WriteLine(productsList[i]);
            }
            //For Loop Pratice
            //Created a loop that prints out the numbers 1 to 10
            for (int i = 1; i < 11; i = i + 1)
            {
                Console.WriteLine(i);
            }
            //Create a loop that prints out numbers 10 to 1
            for (int i = 10; i > 0; i = i - 1)
            {
                Console.WriteLine(i);
            }
            //Create a loop that prints out the numbers 10 to 30 only printing the even numbers
            for (int i = 10; i <= 30; i = i + 2)
            {
                Console.WriteLine(i);
            }
            //Create a loop that prints out the numbers 100 to 75 only printing every 5th number
            for (int i = 100; i >= 75; i = i - 5)
            {
                Console.WriteLine(i);
            }
            
            
            whileLoops();
            puttingItTogether();
            Greeting("Beef Hardchest");
            Greeting(myName);
            DoubleIt(1337);
            DoubleIt(myAge);
            Multiply(2, 8);
            Multiply(3, myAge);
            LoopThis(20, 30);
            LoopThis(0, myAge);
            superLoop(0, 100, 15);
            superLoop(0, 200, myAge);
            Console.WriteLine(newGreeting("Neil degrasse-Tyson"));
            Console.WriteLine(newGreeting(myName));
            Console.WriteLine("10 tripled is " + tripleIt(10));
            Console.WriteLine(myAge + " tripled is " + tripleIt(myAge));
            Console.WriteLine(RealMultiply(5, 10));
            Console.WriteLine(RealMultiply(2, myAge));
            superLoop(RealMultiply(1, 5), tripleIt(myAge), tripleIt(myAge - 10));
            superLoop(RealMultiply(1, tripleIt(3)), tripleIt(RealMultiply(myAge, 7)), tripleIt(myAge - RealMultiply(2, 4)));


                
            


                Console.ReadKey();

            
            

        }

        //Whileloops pratice
        static void whileLoops()
        {
            //Create a while loop that prints out the numbers 1 to 10
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }
            //Creat a while loop that prints out the numbers 10 to 1
            int a = 10;
            while (a > 0)
            {
                Console.WriteLine(a);
                a--;
            }
            //Creat a while loop that prints out the numbers from 15 to 30, only printing the even numbers.
            int b = 16;
            while (b < 30)
            {
                Console.WriteLine(b);
                b = b + 2;
            }
            //Creat a while loop that prints out  the numbers from 100 to 75 , only printing every 5th number.
            int c = 100;
            while (c > 70)
            {
                Console.WriteLine(c);
                c = c - 5;
            }

            //Create a while loop with the condition of: while (myBool){} Print out the numbers from 1 to 10 
            //until it reaches one that is divisible by 4, when your loop finds a number divisable by 4,
            //set the myBool to false.
            int d = 1;
            bool myBool = true;
            while (myBool)
            {
                if (d % 4 == 0)
                {
                    myBool = false;
                    Console.WriteLine(myBool);
                }
                else
                {
                    Console.WriteLine(d);
                    d = d + 1;
                    

                }
            }
           


          
        }
        //putting it together section
        static void puttingItTogether()
        {
            //Print out the number of letters in your name using the format: "My name, <myName>, has, <number of letters> in it.
            string myName = "Nick";
            Console.WriteLine("My name " + myName + " has " + myName.Length + " letters in it");

            //Print out the number of items in your list using the format: "My product list has <numbers of items in it>
            List<string> productsList = new List<string>() { "basketball", "Baseball glove", "tennis shoes", "hockey puck" };
            Console.WriteLine("My Product list has " + productsList.Count + " items in it.");

            //Print out the number of letters in eah item in the productsList using the format: <product> has <number of letters> in it
            for (int i = 0; i < productsList.Count; i++)
            {
                Console.Write(productsList[i]);
                Console.Write(" has ");
                Console.Write(productsList[i].Count(char.IsLetter));
                Console.Write(" letters in it.");
                Console.WriteLine();

                Console.WriteLine(productsList[i] + " has " + productsList[i].Count(char.IsLetter) + " in it.");
            }


        }
        //Create a function called Greeting that takes one string paramater called "name" 
        //This function will print "Hello <name>"
        static void Greeting (string name) 
        {
            Console.WriteLine("Hello " + name);
        }
        //Create a function called "doubleIt" that takes one integer parameter called "number" 
        //This function will print "<number> doubled is <number * 2>
        static void DoubleIt(int number)
        {
            Console.WriteLine(number + " doubled is " + number * 2);
        }
        //Create a function called "multiply" that takes 2 interger parameters called num 1 and num 2
        //This function will print <num1> times <num2> is <num1 * num2>
        static void Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 + " times " + num2 + " is " + num1 * num2);
        }
        //Create a function called "loop this" that takes two integer parameters called "startNum"
        //and "endNum" This function will print out: a. I'm looping from <startNum> to <endNum> 
        //b.The number from startNum to endNum one per line
        static void LoopThis(int startNum, int endNum)
        {
            for (int i = startNum; i < endNum; i++) 
            {
                Console.WriteLine("I'm looping from " + startNum + " to " + endNum);
                Console.WriteLine(i);


            }
        }
        //Create a function called superloop that takes three integer parameters called "startNum
        //"endNum" and "increment"z
        static void superLoop(int startNum, int endNum, int Increment)
        {
            int count = 0;
            for (int i = startNum; i < endNum; i = i + Increment)
            {
                Console.WriteLine("I'm looping from " + startNum + " to " + endNum + " incrementing " + Increment + " each time");
                Console.WriteLine(i);
                count++;
               
                           
            }
            Console.WriteLine("I looped " + count + " times");


        }
        //Create a function called newGreeting that takes one string parameter called "name"
        //This function will return a string in the format of "Hello <name>"
        static string newGreeting(string name)
        {
            return "hello " + name;
        }
        //Create a function called TripleIt that takes one integer parameter called "number
        //This function will return the number times 3
        static int tripleIt(int number)
        {
           return number * 3;
        }
        //Create a function called Real Multiply that takes two integer parameters called "num1" and "num2"
        //This function will return the num1 * num2
        static int RealMultiply(int num1, int num2)
        {
            return num1 * num2;
        }
     }
}

        
        
        

        

    
    




