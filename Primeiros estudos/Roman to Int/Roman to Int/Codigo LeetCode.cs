using System;
namespace RomanToIntCodigoLeetCode { 
    public class Solution
    {
        public int RomanToInt(string s)
        {
            Solution program = new Solution();
            string[] stringromanNumbers = { "I", "V", "X", "L", "C", "D", "M" };
            int[] intconvertedNumbers = { 1, 5, 10, 50, 100, 500, 1000 };

            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                char currentLetter = s[i];
                int indexcurrentLetter = Array.IndexOf(stringromanNumbers, currentLetter.ToString());
                if (i < s.Length - 1)
                {
                    char nextLetter = s[i + 1];
                    int indexnextLetter = Array.IndexOf(stringromanNumbers, nextLetter.ToString());
                    if (indexcurrentLetter < indexnextLetter)
                    {
                        result -= intconvertedNumbers[indexcurrentLetter];
                    }
                    else
                    {
                        result += intconvertedNumbers[indexcurrentLetter];
                    }
                }
                else
                {
                    result += intconvertedNumbers[indexcurrentLetter];
                }
            }
            return result;
        }
    }
}