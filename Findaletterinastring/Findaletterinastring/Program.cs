using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Findaletterinastring
{
    class Program
    {
        static void Main(string[] args)
        {
            letterFinder("t", "There are tottally a lot of t's in this sentence");
            Console.ReadKey();
        }
        static void letterFinder(string lettertofind, string stringtosearch)
        {
            //declare a counter for number of matches
            int count = 0;
            //Loop through each letter of the string to search
            for (int i = 0; i < stringtosearch.Length; i = i + 1)
            {
                //Gets a letter from the string and coverts it to lower case
                string currrentLetter = stringtosearch[i].ToString().ToLower();

                if (currrentLetter == lettertofind.ToLower())
                {
                    //found a match
                    count = count + 1;
                    
                }

            }
            Console.WriteLine(count);

        }
    }
}
        
    
