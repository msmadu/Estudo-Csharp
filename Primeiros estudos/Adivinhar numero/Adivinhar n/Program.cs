//Applied content: Program Structure; Basic Syntax; Data Types; Type Conversion; Variables; Constants; Operators; Decision Making; Loops.
//Page with content: https://www.tutorialspoint.com/csharp/index.htm and Programming Language Module from the Balta.io course

using System;

namespace NumberGame
{
    public class Program
    {
        Random random = new Random();
        public int secretNumber;
        public int wrongGuess;

        public Program()
        {
            secretNumber = random.Next(101);
        }
        static void Main(stringargs)
        {
            Program round = new Program();
            int guess;
            bool guessChecked = false;
            bool win = false;


            while (!guessChecked || !win)
            {
                Console.WriteLine("enter a value:");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                if (int.TryParse(input, out guess))
                {
                    guessChecked = true;
                    round.Tips(round.secretNumber, guess, ref win);
                }
            }

        }

        public void Tips(int secretNumber, int guess, ref bool win)
        {
            if (guess != secretNumber)
            {
                wrongGuess += 1;
                if (guess > secretNumber && wrongGuess < 5)
                {
                    Console.WriteLine("* The guess is GREATER than the secret number");
                }
                else
                {
                    Console.WriteLine("* The guess is LESS than the secret number");
                }
            }
            else
            {
                Console.WriteLine("Congratulations you guessed it! The secret number was {0}", secretNumber);
                win = true;
                wrongGuess += 1;
            }

            switch (wrongGuess)
            {
                case 1:
                    if (Prime(secretNumber))
                    {
                        Console.WriteLine("* The secret number is prime.");
                    }
                    else
                    {
                        Console.WriteLine("* The secret number is NOT prime.");
                    }
                    break;
                case 2:
                    if ((secretNumber % 2) == 0)
                    {
                        Console.WriteLine("* The secret number is a multiple of two");
                    }
                    else
                    {
                        Console.WriteLine("* The secret number is NOT a multiple of two");
                    }
                    break;
                case 3:
                    if ((secretNumber % 3) == 0)
                    {
                        Console.WriteLine("* The secret number is a multiple of three");
                    }
                    else
                    {
                        Console.WriteLine("* The secret number is NOT a multiple of three");
                    }
                    break;
                case 4:
                    var mult = guess * secretNumber;
                    Console.WriteLine("* ATTENTION THIS IS YOUR LAST CHANCE");
                    Console.WriteLine("* Your guess multiplied by the secret number equals: {0}", mult);
                    break;
                default:
                    Console.WriteLine("You lost, the secret number was {0}", secretNumber);
                    win = true;
                    break;
            }


        }

        public static bool Prime(int secretNumber)
        {
            if (secretNumber <= 1) return false;
            if (secretNumber == 2) return true;
            if (secretNumber % 2 == 0) return false;

            for (int i = 3; i <= Math.Sqrt(secretNumber); i += 2)
            {
                if (secretNumber % i == 0) return false;
            }

            return true;
        }


    }
}