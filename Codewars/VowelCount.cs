using System;

namespace Codewars
{
    public class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            int vowelCount = 0;

            // Your code here
            char aA = 'a';
            char eE = 'e';
            char iI = 'i';
            char oO = 'o';
            char uU = 'u';

            for (int i = 0; i < str.Length; i++)
            {
                if (
                    str[i] == aA ||
                    str[i] == eE ||
                    str[i] == iI ||
                    str[i] == oO ||
                    str[i] == uU
                   )
                {
                    vowelCount++;
                }
            }
            return vowelCount;
        }
    }
}
