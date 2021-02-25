using System;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {

            //UserInstruction();  // Guidelines and rules for the game presented on the screen for the user
            InitSecretWord(); // This is where the secret word is randomized and where the secret words are defined and stored


            do

            {

                Console.WriteLine("Please select how you would like to guess the word\n1: By a single character\n2: By a full word");
                Console.WriteLine();

                char userKeyPress = Console.ReadKey(true).KeyChar;

                switch (userKeyPress)
                {
                    case '1':
                        SingleChar();
                        break;

                    case '2':
                        FullWord();
                        break;

                    default:
                        Console.WriteLine("You have entered the wrong number");
                        break;
                }
                Console.WriteLine("Press y to continue or another key too exit.");
            } while (Console.ReadKey(true).KeyChar == 'y');

        }

        static void UserInstruction()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to your free trial of Hangman");
            Console.WriteLine();
            Console.WriteLine("It is simple to use, the instruction how to use it is as following:");
            Console.WriteLine();
            Console.WriteLine("You should guess a word with a maximum length of 4 characters.");
            Console.WriteLine("You will have 10 trials to guess the word, otherwise the computer win and you will lose the game.");
            Console.WriteLine();
            Console.WriteLine("You have two different options to play the game:");
            Console.WriteLine("The first option is to guess a specific character in a word of 4 characters.");
            Console.WriteLine("The second option is to guess for a complete word with 4 characters selected by the computer.");
            Console.WriteLine("Note that in option 2 you will win the whole game if you guess the right word within 10 trials.");
            Console.WriteLine();
        }

        static void InitSecretWord()
        {
            string[] secretWord = new string[10];
            secretWord[0] = "olle";
            secretWord[1] = "karl";
            secretWord[2] = "bo";
            secretWord[3] = "ulf";
            secretWord[4] = "pia";
            secretWord[5] = "ann";
            secretWord[6] = "mona";
            secretWord[7] = "nina";
            secretWord[8] = "lisa";
            secretWord[9] = "ida";

            Random rnd = new Random();
            int rndName = (rnd.Next(0, 9)); // If the amount of secret words is changed, change this parameter accordingly
            string secretWordDefined = secretWord[rndName];

            string [] secretChar = new string[4];
            secretChar[0] = "l";
            secretChar[1] = "a";
            secretChar[2] = "r";
            secretChar[3] = "s";
            Console.WriteLine("Skriv ut Secretchar " + rndName);
            Console.WriteLine("Skriv ut Secretchar " + secretChar[3]);

        }

        static void SingleChar()
        {
            for (int i = 1; i < 7; i++)
            {
                Console.WriteLine();
                Console.Write("\tDu har så här många försök kvar " + (7-i));
                Console.WriteLine("Please type your character: ");
                char userKeyInput = Console.ReadKey(true).KeyChar;
                if (userKeyInput == 'l' )
                {
                  //  Console.WriteLine("Du har tryckt på l " + secretChar[0]);
                    Console.WriteLine("your guess is right");
                  //   Console.WriteLine("Skriv ut Secretchar " + secretChar[3]);

                }
                if (userKeyInput == 'a')
                {
                Console.WriteLine("your guess is right");
                }
                if (userKeyInput == 'r')
                    {
                    Console.WriteLine("your guess is right");
                    }
                if (userKeyInput == 's')
                    {
                    Console.WriteLine("your guess is right");
                    }
                Console.WriteLine("your guess is wrong");
            }
        }

        static void FullWord()
        {
            Console.Write("Count down to zero from: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while (number >= 0)
            {
                Console.WriteLine("Number is: " + number--);
            }
        }

        static void AboutMe()
        {
            Console.WriteLine("My name is Ulf");
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

    } //end of class program
} // end of namespace
