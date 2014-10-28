using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPratice
{
    class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            Console.ReadKey();
            int myAgeDoubled = DoubleIt(31);
            Console.WriteLine(DoubleIt(myAgeDoubled));
        }

///<summary>
/// Writes  "hello world to the console"
///</summary>
static void HelloWorld()
{
   Console.WriteLine("Hello World!");
}




static int DoubleIt(int someNumber)
{
	return someNumber * 2;
}


static void LoopSomeNumbers(int startNumber, int endNumber)
{
    for (int i = startNumber; i <= endNumber; i = i + 1) ;
}

/// <summary>
/// Runs a serires of tests on our loopSomeNumbers function
/// </summary>
static void LoopTests()
{
    LoopSomeNumbers(5, 10);
    LoopSomeNumbers(863428, 863430);
    LoopSomeNumbers(31, DoubleIt(31));
}
        /// <summary>
        /// Returns the number of vowels in a string
        /// </summary>
        /// <param name="A string that you want to count the vowles in"></param>
        /// <returns>The nuber of vowels found</returns>
static int VowelCounter3000(string inputString)
{
    //declare a counter for the vowels
    int numberOfVowelsFound = 0;

    //Loop over each letter of the string
    for (int i = 0; i < inputString.Length; i = i + 1)
    {
        string letter = inputString[i].ToString().ToLower();

        if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
        {
            //Found a vowel! huzzah!
            numberOfVowelsFound++;

        }
        //alertenet we of checking to see if its a vowel
        if ("aeiou".Contains(letter))
        {

        }

        
    }
    //loop complete, time to write the output
    Console.WriteLine(inputString + " has " + numberOfVowelsFound + " vowles in it");
    return numberOfVowelsFound;
}
        static void VowelCouner3000Tests()
        {
    int totalNumberOfVowelsCounted = 0;
    totalNumberOfVowelsCounted =+ VowelCounter3000("jackie seems to like music");
    totalNumberOfVowelsCounted = +VowelCounter3000("I love to eat");
    Console.WriteLine("Total Vowelss Counted: " + totalNumberOfVowelsCounted);
}

    }
}
