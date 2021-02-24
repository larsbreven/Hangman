using System;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // 

            Console.WriteLine();
            Console.WriteLine("Please use our basic calculator to do a calculation");
            Console.WriteLine("It is easy to use, just follow the instructions below");
            Console.WriteLine();
            Console.WriteLine();
            do
            {
                Console.WriteLine("Enter a number from the menu below for the desired calculation");
                Console.WriteLine("\n1: Addition\n2: Subtraction\n3: Multiplication\n4: Division\n");
                char userInput = Console.ReadKey(true).KeyChar;
                switch (userInput)
                {
                    case '1':
                        Addition();
                        break;
                    case '2':
                        Subtraction();
                        break;
                    case '3':
                        Multiplication();
                        break;
                    case '4':
                        Division();
                        break;

                    default:
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("Press c to continue, any other key to exit the calculator ");
            }
            while (Console.ReadKey(true).KeyChar == 'c');
        }

        static void Addition()
        {
            Console.WriteLine("");
            Console.Write("Enter the first number to be calculated : ");
            double FirstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number to be calculated: ");
            double SecondNum = Convert.ToDouble(Console.ReadLine());
            double TheResult = FirstNum + SecondNum;
            Console.WriteLine("The result of the calculation is:         " + TheResult);
        }

        static void Subtraction()
        {
            Console.WriteLine("");
            Console.Write("Enter the first number to be calculated : ");
            double FirstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number to be calculated: ");
            double SecondNum = Convert.ToDouble(Console.ReadLine());
            double TheResult = FirstNum - SecondNum;
            Console.WriteLine("The result of the calculation is:         " + TheResult);
        }

        static void Multiplication()
        {
            Console.WriteLine("");
            Console.Write("Enter the first number to be calculated : ");
            double FirstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number to be calculated: ");
            double SecondNum = Convert.ToDouble(Console.ReadLine());
            double TheResult = FirstNum * SecondNum;
            Console.WriteLine("The result of the calculation is:         " + TheResult);
        }

        static void Division()
        {
            Console.WriteLine("");
            Console.Write("Enter the first number to be calculated:  ");
            double FirstNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second number to be calculated: ");
            double SecondNum = Convert.ToDouble(Console.ReadLine());
            if (SecondNum == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("You have entered: " + SecondNum);
                Console.WriteLine("Please note the entered value is not valid");
            }
            else
            {
                double TheResult = FirstNum / SecondNum;
                Console.WriteLine("The result of the calculation is:         " + TheResult);
            }
        }

        static string AskUserFor(string what)
        {
            Console.Write($"Please type in {what}: ");
            return Console.ReadLine();
        }

        static int AskUserFor(string what, bool isNumber)
        {
            return Convert.ToInt32(AskUserFor(what));
        }


    }

       

       








       
    
}
