using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HU_M01L04_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Show the number if it's bigger then X or smaller then Y 
            Console.WriteLine("Please enter an integer");
            int integerA = int.Parse(Console.ReadLine());
            int bigNum = 938;
            int smallNum = 532;
            if ((integerA > bigNum) || (integerA < smallNum))
            {
                Console.WriteLine(integerA + " is bigger then " + bigNum + " and smaller then " + smallNum);
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
