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
            //loop for fizzbuzz
            string myString = "";
            for (int i = 0; i < 21; i++)
            {
                Fizzbuzz(i);
            }
            //loop for fizzbuzz
            for (int i = 92; i > 78; i--)
            {
                Fizzbuzz(i);
            }
            //calling yodaizer function
            yodaizer("I like code");
            //calling textstats function and writing it to the console
            Console.WriteLine(textstats("I like coding, it's lots of fun. All I have to do is type words and stuff happens. I also like star trek, but that has nothing to do with coding."));
            
            //loop for isPrime function
            for (int i = 1; i <= 25; i++)
            {
                if (i % 2 != 0)
                {
                    if (isPrime(i) == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            //calling dashInsert function
            dashInsert(8675309);


            //keeps the console open until you hit a key
                Console.ReadKey();
        }
        static void Fizzbuzz(int number)
        {
            //checking to see if number is divisiable by 3 or 5
            if (number % 3 == 0 && number % 5 == 0)
            {
                //writing to the console if it is
                Console.WriteLine("Fizz Buzz");
            }
                //checking to see if the number is divisable by 3
            else if (number % 3 == 0)
            {
                //writing to the console if it is
                Console.WriteLine("Fizz");
            }
                //checking to see if the number is divisable by 5
            else if (number % 5 == 0)
            {
                //writing to the console if it is
                Console.WriteLine("Buzz");
            }
            else
            {
                //writing the number to the console if it not divisable by 5 or 3 or both
                Console.WriteLine(number);
            }
        }

        static void yodaizer(string text)
        {
            //converting my string to a array by splitting it on the space charater
            string[] array = text.Split(' ');
            //starting a loop to go over the new array and make the words backwards
            for(int i = array.Count()-1; i >= 0; i--)
            {
                //making sure the array is less than 3
                if (array.Count() < 4)
                {
                    //writing to the console
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
            //defining all my variables
            int min = 1;
            int max = 0;
            int smax = 0;
            string shortest = "";
            string sLongest = "";
            string longest = "";
            string outputstring = " ";
            int numofspecialchars = 0;
            int numofConsonants = 0;
            int numofvowles = 0;
            int listcount = 0;
            //printing the length of the string
            Console.WriteLine(input.Length);
            string[] newlist = input.Split(' ');
            listcount = newlist.Count();
            //printing the length of the list
            Console.WriteLine(listcount);
            //starting a loop to go over the string
            for (int i = 0; i < input.Length; i++)
            {
                //finding vowles
                string letter = input[i].ToString().ToLower();
                if ("aeiou".Contains(letter))
                {
                    //adding to my vowel counter
                    numofvowles++;                                        
              
                }
                    //finding consonants
                else if ("bcdfghjlkmnpqrstvwzyx".Contains(letter))
                {
                    //adding to consonants counter
                    numofConsonants++;
                }
                    //finding special charaters
                else if (" ?.".Contains(letter))
                {
                    //adding to special charater counter
                    numofspecialchars++;
                }
                 
            }
            //loop to go over list to find shortest, longest, and second shortest word
            for (int i = 1; i < newlist.Count(); i++)
            {   //finding the longest word
                if (newlist[i].Count() > max)
                {
                    //increasing counter and setting string to longest word
                    max = newlist[i].Count();
                    longest = newlist[i].ToString();
                }
                
                //finding second longest word
                if (newlist[i].Count() < max && newlist[i].Count() > smax)
                {
                    //setting the counter and string
                    smax = newlist[i].Count();
                    sLongest = newlist[i].ToString();

                }
                //finding the min word
                if (newlist[i].Count() < max && newlist[i].Count() < smax)
                {
                    min = newlist[i].Count();
                    //compairing current word to last min word found
                        if(newlist[i].Count() < min)
                        {
                            //setting counter and string
                            min = newlist[i].Count();
                            shortest = newlist[i].ToString();
                        }

                        
                }
            }


            //creating the output string to return when function is called
            outputstring = "String has " + numofvowles + " vowles," + numofConsonants + "  Consonants and " + numofspecialchars + " special charaters in it" + "\r\n" + " the longest word is " + longest + " and is " + max + " charaters " + "\r\n" + " the shortest word is " + shortest + " and is " + min + " charaters " + "\r\n" + " the Second longest is " + sLongest + " and is "+ smax + " charaters";
            return outputstring;
        }

        static bool isPrime(int number)
        {
            //setting boolian
            bool prime = false;
            //creating loop to see if number is prime
            for (int i = 2; i < number; i++)
            {
                
                if (number % i == 0)
                {
                    //not prime
                    prime = false;
                    break;
                    
                }

                else
                {
                    //is prime
                    prime = true;
                    
                }

            } return prime; 

        }

        static void dashInsert(int number)
        {
            //converting numbers to string
            string numstring = number.ToString();
            //creating loop to check if numbers are odd and to put a - beteween them
            for (int i = 0; i <= numstring.Length - 1; i++)
            {
                //checking if numbers are odd
                if (int.Parse(numstring[i].ToString()) % 2 != 0)
                {
                    //checking if the last number checked was odd
                    if (int.Parse(numstring[i - 1].ToString()) % 2 != 0)
                    {
                        //writing dash beteween numbers
                        Console.Write("-" + numstring[i].ToString());

                    }
                    else
                    {
                        //writing number if last number was not odd
                        Console.Write(numstring[i].ToString());

                    }


                }
                else
                {
                    //writing even numbers
                    Console.Write(numstring[i].ToString());
                }
            }
        }
                
    }       
}      

    