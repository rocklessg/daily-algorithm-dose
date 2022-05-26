using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class Pangram
    {
        public static string pangrams(string s)
        {
            var englishLetters = ("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            var newLetter = string.Empty;
            var removeSpace = s.Replace(" ", "").ToLower();

            for (int i = 0; i < removeSpace.Length; i++)
            {
                if (newLetter.Contains(removeSpace[i]))
                {
                    continue;
                }
                newLetter += removeSpace[i];
            }
            if (newLetter.Length == englishLetters.Length)
            {
                return "pangram";
            }
            return "not pangram";
        }
    }
}
