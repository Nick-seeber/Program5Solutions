using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            groupPicker();
            Console.ReadKey();
        }

        static void groupPicker()
        {
            List<int> studentNumber = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            List<int> group = new List<int>() { };
            Random rng = new Random();
            
            for (int i = 0; i < studentNumber.Count; i++) 
            {
                if (group[i] > studentNumber.Count)
                {
                    int numGen = rng.Next();
                    studentNumber.Remove(numGen);
                    group.Add(numGen);
                    Console.WriteLine(group);

                    

                }
            } 

        }   
    }
}
