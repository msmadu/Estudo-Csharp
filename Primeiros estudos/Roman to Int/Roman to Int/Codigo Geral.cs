using System;

namespace RomanToIntConsole
{
    public class Program
    {
        static void Main(string userInput)
        {
            Program program = new Program();
            stringromanNumbers = { "I", "V", "X", "L", "C", "D", "M" };
            intconvertedNumbers = { 1, 5, 10, 50, 100, 500, 1000 };
            Console.WriteLine("Enter a value in roman romanNumbers");

            do
            {
                userInput = Console.ReadLine().ToUpper();
            } while (string.IsNullOrEmpty(userInput) || userInput.Length > 15 || Validate(userInput, romanNumbers) == false);

            int result = program.RomanToInt(userInput, romanNumbers, convertedNumbers);
            Console.WriteLine(result);
        }

        public static bool Validate(string result, stringromanNumbers)
        {
            foreach (char c in result)
            {
                if (Array.IndexOf(romanNumbers, c.ToString()) < 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int RomanToInt(string userInput, stringromanNumbers, intconvertedNumbers)
        {
            int result = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                char currentLetter = userInput[i];
                int indexCurrentLetter = Array.IndexOf(romanNumbers, currentLetter.ToString());
                if (i < userInput.Length - 1)
                {
                    char nextLetter = userInput[i + 1];
                    int indexNextLetter = Array.IndexOf(romanNumbers, nextLetter.ToString());
                    if (indexCurrentLetter < indexNextLetter)
                    {
                        result -= convertedNumbers[indexCurrentLetter];
                    }
                    else
                    {
                        result += convertedNumbers[indexCurrentLetter];
                    }
                }
                else
                {
                    result += convertedNumbers[indexCurrentLetter];
                }
            }
            return result;
        }
    }
}