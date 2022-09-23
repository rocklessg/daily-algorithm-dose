using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coderbyte
{
    public class BracketCombination
    {
        public static int BracketCombinations(int num)
        {

            // code goes here
            //int counter = 0;
            // int pair = num * 2;
            // int[] arr = new int[pair + 1];

            // for (int i = pair; i > 0; i--)
            // {
            //   arr[i] = i;
            // Console.WriteLine( 1 / 2);
            // }
            // for (var ar = 0; ar < arr.Length; ar++)
            // {
            //   if (arr[ar] % 2 == 0 && arr[ar + 1] % 2 == 1)
            //   {
            //     counter++;
            //   }
            // }
            //return counter;
            double a = Factorial(2 * num) / (Factorial(num) * Factorial(num + 1));
            return (int)a;

        }

        static double Factorial(int num)
        {
            double a = 1;
            for (int i = num; i > 0; i--)
            {
                a *= i;
            }
            return a;
        }
    }
}
/*
                    Bracket Combinations
        Have the function BracketCombinations(num) read num which will
        be an integer greater than or equal to zero, and return the number
        of valid combinations that can be formed with num pairs of parentheses.
        For example, if the input is 3, then the possible combinations of 3 pairs
        of parenthesis, namely: ()()(),
        are ()()(), ()(()), (())(), ((())), and (()()). There are 5 total combinations
        when the input is 3, so your program should return 5.

        Examples
        Input: 3
        Output: 5
        Input: 2
        Output: 2
 */