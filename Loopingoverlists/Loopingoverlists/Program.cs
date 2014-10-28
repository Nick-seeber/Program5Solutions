using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loopingoverlists
{
    class Program
    {
        static void Main(string[] args)
        {
            loopOverAList();
            LoopOverWordsInAString("The quick brown fox jumps over the lazy dog");
            Console.ReadKey();
        }
        static void loopOverAList()
        {
            //Created a list of sports
            List<string> sportsList = new List<string>() { "Baseball", "Tennis" };
            //add football to the sports list
            sportsList.Add("Football");
            //loop over the spots list and display all elements that contain the word "ball"
            for (int i = 0; i < sportsList.Count(); i = i + 1)
            {
                //get the urrent sport out of sportsList
                string currentSport = sportsList[i];
                //check tto see if its a sport with the word ball in it
                if (currentSport.Contains("ball"))
                {
                    //its true
                    Console.WriteLine(currentSport);    
                }

            }
        }
        /// <summary>
        /// Print out each word of a string, one per line
        /// </summary>
        /// <param name=>string to loop over</param>
        static void LoopOverWordsInAString(String inputString)
        {
            List<string> wordlist = inputString.Split(' ').ToList();
            for (int i = 0; i < wordlist.Count(); i = i + 1)
            {
                Console.WriteLine(wordlist[i]);
            }
        }
    }
}
