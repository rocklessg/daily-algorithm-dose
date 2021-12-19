using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit
{
    public class RepeatString
    {
        public static long RepeatedString(string s, long n)
        {
            // holds the number of occurence of 'a'
            long aCounter = 0;

            long remainderCounter = 0;
            long remaiderLength = (n % s.Length); // size of remaining letters

            // Iterate over the string
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'a')
                {
                    // Increment 'a' count in the string
                    aCounter++;

                    // Doing some check
                    if (i < remaiderLength)
                    {
                        remainderCounter++;
                    }
                }
            }
            return aCounter * (n / s.Length) + remainderCounter;
        }

    }

//There is a string, , of lowercase English letters that is repeated
//infinitely many times.Given an integer, , find and print the number
//of letter a's in the first  letters of the infinite string.

//Example


//The substring we consider is , the first  characters of the infinite string. 
//There are  occurrences of a in the substring.

//Function Description

//Complete the repeatedString function in the editor below.

//repeatedString has the following parameter(s):

//s: a string to repeat
//n: the number of characters to consider
//Returns

//int: the frequency of a in the substring
//Input Format

//The first line contains a single string, .
//The second line contains an integer, .

//Constraints

//For  of the test cases, .
//Sample Input

//Sample Input 0

//aba
//10
//Sample Output 0

//7
//Explanation 0
//The first  letters of the infinite string are abaabaabaa.Because there are a's, we return .

//Sample Input 1

//a
//1000000000000
//Sample Output 1

//1000000000000
//Explanation 1
//Because all of the first letters of the infinite string are a, we return .

}
