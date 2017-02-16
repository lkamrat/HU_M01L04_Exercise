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
            //// Show the number if it's bigger then X or smaller then Y 
            //Console.WriteLine("Please enter an integer");
            //int integerA = int.Parse(Console.ReadLine());
            //int bigNum = 938;
            //int smallNum = 532;
            //if (integerA > bigNum)
            //{
            //    Console.WriteLine(integerA + " is bigger then " + bigNum);
            //}
            //else
            //{
            //    if (integerA < smallNum)
            //    {
            //        Console.WriteLine(integerA + " is smaller then " + smallNum);
            //    }
            //    else
            //    {
            //        Console.WriteLine("No match");
            //    }
            //}

            //// Identify an even or a negitive number
            //Console.WriteLine("Please enter an even, odd or negetive integer");
            //int anyInteger = int.Parse(Console.ReadLine());
            //if ((anyInteger < 0))
            //{
            //    Console.WriteLine(anyInteger + " is a negetive number");
            //}
            //else
            //{
            //    if ((anyInteger % 2 == 0))
            //    {
            //        Console.WriteLine(anyInteger + " is an even number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("No match");
            //    }
            //}

            // Identify the highest and lowest number
            // Show numbers in an ascending order
            //Console.WriteLine("Please enter three integers");
            //int intA = int.Parse(Console.ReadLine());
            //int intB = int.Parse(Console.ReadLine());
            //int intC = int.Parse(Console.ReadLine());

            //if ((intA >= intB) && (intA >= intC))
            //{
            //    Console.WriteLine(intA + " is the highest number");
            //}
            //else
            //{
            //    if ((intB >= intA) && (intB >= intC))
            //    {
            //        Console.WriteLine(intB + " is the highest number ");
            //    }
            //    else
            //    {
            //        if ((intC >= intA) && (intC >= intB))
            //        {
            //            Console.WriteLine(intC + " is the highest number ");
            //        }
            //    }
            //}
            //if ((intA <= intB) && (intA <= intC))
            //{
            //    Console.WriteLine(intA + " is the lowest number");
            //}
            //else
            //{
            //    if ((intB <= intA) && (intB <= intC))
            //    {
            //        Console.WriteLine(intB + " is the lowest number");
            //    }
            //    else
            //    {
            //        if ((intC <= intA) && (intC <= intB))
            //        {
            //            Console.WriteLine(intC + " is the lowest number");
            //        }
            //    }   
            //}

            //// Identify if a number is positive, negative or 0
            //Console.WriteLine("Please enter positive, negative or zeroed number");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine(number + " is a positive number");
            //}
            //else
            //{
            //    if (number < 0)
            //    {
            //        Console.WriteLine(number + " is a negative number");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Zero");
            //    }
            //}

            // Check if the player match the acceptance criteria
            Console.WriteLine("Please enter player's age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter player's hight in cm");
            int hight = int.Parse(Console.ReadLine());
            if ((((age >= 14) && (age <= 18)) || ((age >= 21) && (age <= 26))) && (hight >= 182)) 
            {
                Console.WriteLine("Player's age is " + age);
                Console.WriteLine("Player's hight is " + hight);
                Console.WriteLine("The player has been accepted to Maccabi Tel-Aviv");
            }
            else
            {
                Console.WriteLine("Player's age is " + age);
                Console.WriteLine("Player's hight is " + hight);
                Console.WriteLine("The player has been rejected by Maccabi Tel-Aviv");
            }
        }

    }
}
