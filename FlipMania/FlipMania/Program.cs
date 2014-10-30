using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            flipCoin(10000);
            flipForHeads(10000);
            Console.ReadKey();
        }
        static void flipCoin(int numberOfFlips)
        {
            int numOfHeads = 0;
            int numOfTails = 0;
            Random rng = new Random();
            for (int i = 0; i < numberOfFlips; i++)
            {
                            
                int flip = rng.Next(1, 3);
                if (flip == 1)
                {
                    
                    numOfHeads = numOfHeads + 1;

                }
                else
                {
                    
                    numOfTails = numOfTails + 1;
                }

               
            }
            Console.WriteLine("We flipped a coin: " + numberOfFlips + " times");
            Console.WriteLine("Number of Heads: " + numOfTails);
            Console.WriteLine("Number of Tails: " + numOfHeads);
            

        }
        
        static void flipForHeads(int numOfHeads)
        {
            int numOfHeadsFliped = 0;
            int totalFlips = 0;
            Random rng = new Random();
            while (numOfHeadsFliped < numOfHeads)
            {
                int flip = rng.Next(1, 3);
                if (flip == 1)
                {
                    numOfHeadsFliped = numOfHeadsFliped + 1;
                    totalFlips = totalFlips + 1;
                }
                else
                {
                    totalFlips = totalFlips + 1;
                }
            }
            Console.WriteLine("We are flipping a coin until we find " + numOfHeads + " heads. It took " + totalFlips + " flips to find " + numOfHeads + " heads ");
        } 
    }
}
