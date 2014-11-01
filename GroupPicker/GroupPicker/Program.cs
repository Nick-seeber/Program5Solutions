using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            group(20, 5);
            Console.ReadKey();
        }

        static void groupPicker()
        {
            
            int counter = 0;
            List<int> Student = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            int loopcount = Student.Count;
            List<int> Group = new List<int>() { };
            Random rng = new Random();
            int num = rng.Next(0, Student.Count);
            for (int i = 0; i < loopcount; i++)
            {


                if (counter < 5)
                {
                    
                    Group.Add(Student[num]);
                    Student.Remove(num);

                }
                else
                {
                    counter = 0;
                    Console.WriteLine("yep");
                    Group.Clear();
                }
                counter++;
            }
     }

        static void pickAGroup()
        {
            int loopcount = 0;
            int count = 0;
            int classSize = 20;
            int groupSize = 5;
            List<int> classList = new List<int>(){1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
            List<int> groupList = new List<int>() { };
            Random rng = new Random();
            for (int i = 0; i < classSize; i++)
            {
                loopcount++;
                if (loopcount < 6)
                {
                    int num = rng.Next(1, classList.Count);
                    int student = num;
                    groupList.Add(student);
                    classList.RemoveAt(student);
                    count++;
               

                }
                else
                {
                    loopcount = 0;
                   
                    for (int x = 1; x < groupList.Count; x++)
                    {
                        Console.Write(groupList[x] + " ");

                    }
                    groupList.Clear();
                    Console.WriteLine();
                }
                
            }
        }

        static void group(int classsize, int groupsize)
        {
            List<int> classList = new List<int>() { };
            List<int> grouplist = new List<int>() { };
            Random groupnumber = new Random();

            for (int i = 0; i < classsize; i++)
            {
                
                classList.Add(i);
            }
            for (int i = classList.Count; i > 0; i--)
            {
                int student = groupnumber.Next(0, classList.Count());
                classList.Remove(student);
                grouplist.Add(student);
                if(grouplist.Count() == groupsize){

                    for (int x = 0; x < grouplist.Count(); x++)

			{


                Console.WriteLine("Group ");
                        Console.WriteLine("# " + grouplist[x]);
                    }
                    grouplist.Clear();
                }
            }
        }

    }
}
