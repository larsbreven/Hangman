using System;
using System.Text;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            //UserInstruction();    // Guidelines and rules for the game presented on the screen for the user
            //InitSecretWord();     // Secret word is randomized, defined and stored
            //PlayCheckGuess();     // Guess the secret word and check result


            Console.WriteLine();                                            // Guidelines and rules presented on the screen
            Console.WriteLine("Welcome to your free trial of Hangman");
            Console.WriteLine();
            Console.WriteLine("It is simple to use, the instruction how to use it is as following:");
            Console.WriteLine();
            Console.WriteLine("You should guess a word with a maximum length of 4 characters.");
            Console.WriteLine("You will have 10 trials to guess the word, otherwise the computer win and you will lose the game.");
            Console.WriteLine();
            Console.WriteLine();



            string[] secretWord = new string[10];                           // All secret words are defined
            secretWord[0] = "olle";
            secretWord[1] = "karl";
            secretWord[2] = "lars";
            secretWord[3] = "lena";
            secretWord[4] = "anna";
            secretWord[5] = "lina";
            secretWord[6] = "mona";
            secretWord[7] = "nina";
            secretWord[8] = "lisa";
            secretWord[9] = "disa";
            Random rnd = new Random();                                      // SecretWord is randomized and defined for usage
            int guessTrials = 5;                                            // Amount of guesstrials are defined, default = 10
            int rndName = (rnd.Next(0, guessTrials));
            string secretWordDefined = secretWord[rndName];
            Console.WriteLine("The secret word is   " + secretWordDefined); // Remove line before operation
            char[] ArraySecretChar = secretWordDefined.ToCharArray();       // Use ToCharArray to convert string to array
            for (int i = 0; i < ArraySecretChar.Length; i++)                // Loop through the array
            {                                                               // Can be removed, check values on console
                                                                            // Console.WriteLine(ArraySecretChar[i]);                       // Write character to console
            }                                                                                                                  // Can be removed, only to check values on console



            int guessCounter = 0;                                           // Player guess the secret word
            for (int i = 0; i < guessTrials; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("You have done " + guessCounter);
                Console.Write(" trial ");
                Console.Write("and you have " + guessTrials);
                Console.WriteLine(" left");
                Console.WriteLine();
                Console.Write("Enter a character: ");
                char userKeyInput = Console.ReadKey(true).KeyChar;
                if (userKeyInput == ArraySecretChar[0]) { Console.WriteLine("your guess is right"); }
                if (userKeyInput == ArraySecretChar[1]) { Console.WriteLine("your guess is right"); }
                if (userKeyInput == ArraySecretChar[2]) { Console.WriteLine("your guess is right"); }
                if (userKeyInput == ArraySecretChar[3]) { Console.WriteLine("your guess is right"); }
                guessCounter++;
                guessTrials--;
                Console.WriteLine();
            }


        } // end of main
    } // end of class program
} // end of namespace