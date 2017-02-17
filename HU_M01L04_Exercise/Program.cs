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
            if (integerA > bigNum)
            {
                Console.WriteLine(integerA + " is bigger then " + bigNum);
            }
            else
            {
                if (integerA < smallNum)
                {
                    Console.WriteLine(integerA + " is smaller then " + smallNum);
                }
                else
                {
                    Console.WriteLine("No match");
                }
            }

            // Identify an even or a negitive number

            Console.WriteLine("Please enter an even, odd or negetive integer");
            int anyInteger = int.Parse(Console.ReadLine());
            if ((anyInteger < 0))
            {
                Console.WriteLine(anyInteger + " is a negetive number");
            }
            else
            {
                if ((anyInteger % 2 == 0))
                {
                    Console.WriteLine(anyInteger + " is an even number");
                }
                else
                {
                    Console.WriteLine("No match");
                }
            }

            // Identify the highest and lowest number
            // Show numbers in an ascending order

            Console.WriteLine("Please enter three integers");
            int intA = int.Parse(Console.ReadLine());
            int intB = int.Parse(Console.ReadLine());
            int intC = int.Parse(Console.ReadLine());

            if ((intA >= intB) && (intA >= intC))
            {
                Console.WriteLine(intA + " is the highest number");
            }
            else
            {
                if ((intB >= intA) && (intB >= intC))
                {
                    Console.WriteLine(intB + " is the highest number ");
                }
                else
                {
                    if ((intC >= intA) && (intC >= intB))
                    {
                        Console.WriteLine(intC + " is the highest number ");
                    }
                }
            }
            if ((intA <= intB) && (intA <= intC))
            {
                Console.WriteLine(intA + " is the lowest number");
            }
            else
            {
                if ((intB <= intA) && (intB <= intC))
                {
                    Console.WriteLine(intB + " is the lowest number");
                }
                else
                {
                    if ((intC <= intA) && (intC <= intB))
                    {
                        Console.WriteLine(intC + " is the lowest number");
                    }
                }
            }
            
            if ((intA >= intB) && (intB >= intC))
            {
                Console.WriteLine("The numbers in an ascending order are {0} {1} {2}:", intC, intB, intA);
            }
            else
            {
                if ((intB >= intA) && (intA >= intC))
                {
                    Console.WriteLine("The numbers in an ascending order are {0} {1} {2}:", intC, intA, intB);
                }
                else
                {
                        Console.WriteLine("The numbers in an ascending order are {0} {1} {2}:", intB, intA, intC);
                }
            }

                // Identify if a number is positive, negative or 0

                Console.WriteLine("Please enter positive, negative or zeroed number");
            int number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine(number + " is a positive number");
            }
            else
            {
                if (number < 0)
                {
                    Console.WriteLine(number + " is a negative number");
                }
                else
                {
                    Console.WriteLine("Zero");
                }
            }

            // Check if the player match the acceptance criteria

            Console.WriteLine("Please enter player's age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter player's hight in cm");
            int hight = int.Parse(Console.ReadLine());
            if ((((age >= 14) && (age <= 18)) || ((age >= 21) && (age <= 26))) && (hight >= 182))
            {
                Console.WriteLine("The player has been accepted to Maccabi Tel-Aviv");
            }
            else
            {
                Console.WriteLine("The player has been rejected by Maccabi Tel-Aviv");
            }

            // Show a student verbal grade evaluation

            Console.WriteLine("Please enter student grade");
            int grade = int.Parse(Console.ReadLine());
            if (grade < 55)
            {
                Console.WriteLine("The grade is insufficient");
            }
            else
            {
                if ((grade >= 55) && (grade <= 64))
                {
                    Console.WriteLine("The grade is sufficient");
                }
                else
                {
                    if ((grade >= 65) && (grade <= 74))
                    {
                        Console.WriteLine("The grade is almost good");
                    }
                    else
                    {
                        if ((grade >= 75) && (grade <= 84))
                        {
                            Console.WriteLine("The grade is good");
                        }
                        else
                        {
                            if ((grade >= 85) && (grade <= 94))
                            {
                                Console.WriteLine("The grade is very good");
                            }
                            else
                            {
                                if (grade >= 95)
                                {
                                    Console.WriteLine("The grade is excellent");
                                }
                            }
                        }
                    }

                }
            }

            // Count to a number

            Console.WriteLine("Please enter a number to count to");
            int theNumberA = int.Parse(Console.ReadLine());
            for (int i = 1; i <= theNumberA; i++)
            {
                Console.WriteLine(i);
            }

            // Count all the even numbers

            Console.WriteLine("Please enter a number to count to");
            int theNumberB = int.Parse(Console.ReadLine());
            for (int i = 2; i <= theNumberB; i += 2)
            {
                Console.WriteLine(i);
            }

            // Sum all the numbers using a loop

            Console.WriteLine("Insert a number");
            int theNumber = int.Parse(Console.ReadLine());
            int sum = theNumber;
            for (int i = 1; i < 10; i++)
            {
                int tempNum = int.Parse(Console.ReadLine());
                sum = sum + tempNum;
            }
            Console.WriteLine("The sum is " + sum);

            // Show the highest and the lowest number out of ten numbers

            Console.WriteLine("Please enter 10 numbers");
            int finalMaxNum = 0;
            for (int i = 0; i < 10; i++)
            {
                int tempMax = int.Parse(Console.ReadLine());
                if (tempMax > finalMaxNum)
                    finalMaxNum = tempMax;
            }

            Console.WriteLine("the highest number is " + finalMaxNum);

            Console.WriteLine("Please enter 10 numbers");
            int finalMinNum = 2147483647;
            for (int i = 0; i < 10; i++)
            {
                int tempMin = int.Parse(Console.ReadLine());
                if (tempMin < finalMinNum)
                    finalMinNum = tempMin;
            }

            Console.WriteLine("the lowest number is " + finalMinNum);

            // Show all the numbers between two random numbers in an ascending order

            Console.WriteLine("Please enter a two numbers");
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                for (int i = numberTwo; i < numberOne; i++)
                {
                    Console.WriteLine(i);
                }
            }
            if (numberOne < numberTwo)
            {
                for (int i = numberOne; i < numberTwo; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
