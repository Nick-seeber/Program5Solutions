using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipManiaAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            flipCoins(700000);
            //insert 3 blank lines
            Console.WriteLine("\n\n");
            flipForHeads(1000000);
            Console.ReadKey();
        }
        static void flipCoins(int numberOfFlips)
        {
            //what data do we need to track
            int numOfHeads = 0;
            int numOfTails = 0;
            //random num gen to flip a coin
            Random coinFlip = new Random();
            for (int i = 0; i < numberOfFlips; i++)
            {
                int coin = coinFlip.Next(0, 2);
                //is it heads?
                if (coin == 1)
                {
                    numOfHeads = numOfHeads + 1;
                }
                else
                {
                    //got a tails, swwet
                    numOfTails = numOfTails + 1;
                }
            }
            Console.WriteLine("we flipped " + numberOfFlips + " times");
            Console.WriteLine("# of heads " + numOfHeads);
            Console.WriteLine("# of tails " + numOfTails);
        }

        static void flipForHeads(int numOfHeads)
        {
            //what data do we need?
            //Whats our output? what info do we need to do this process
            int numOfHeadsFound = 0;
            int totalFlips = 0;
            Random coinFlip = new Random();
            //Great now lets flip some coins
            while (numOfHeadsFound != numOfHeads)
            {
                int coinFlipResult = coinFlip.Next(0, 2);
                //was it a heads?
                if (coinFlipResult == 0)
                {
                    //got heads incrment the count
                    numOfHeadsFound++;
                    totalFlips++;
                }
                else
                {
                    totalFlips++;
                }

            } Console.WriteLine("It took us {0} flips to get {1} heads", totalFlips, numOfHeadsFound);
        }   
    }
}
