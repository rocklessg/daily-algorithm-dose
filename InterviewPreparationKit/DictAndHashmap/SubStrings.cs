using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit.DictAndHashmap
{
    public class SubStrings
    {
        public static string TwoStrings(string s1, string s2)
        {
            // First didn't pass all test cases cos of time complexity
            //var subString = s2.Substring(0);
            //for (var i = 0; i < s1.Length; i++)
            //{
            //    if (s2.Contains(s1[i]))
            //    {
            //        return "Yes";
            //    }
            //}
            //return "No";


            // Optimized version. Yet didn't pass all test cases due to time complexity
            //var check = from s in s1
            //            where s2.Contains(s)
            //            select s;
            //if (check.Any())
            //{
            //    return "YES";
            //}
            //return "NO";

            // Optimized. passed all test cases
            HashSet<char> s1Set = new HashSet<char>();
            foreach (var item in s1.ToCharArray())
            {
                s1Set.Add(item);

            }

            foreach (var item in s2.ToCharArray())
            {
                if (s1Set.Contains(item))
                {
                    return "YES";
                }
            }
            return "NO";

        }
    }
    //Time conplexity issue

//Given two strings, determine if they share a common substring.
//A substring may be as small as one character.

//Example



//These share the common substring.



//These do not share a substring.


//Function Description


//Complete the function twoStrings in the editor below.

//twoStrings has the following parameter(s):


//string s1: a string
//string s2: another string
//Returns


//string: either YES or NO
//Input Format


//The first line contains a single integer , the number of test cases.

//The following  pairs of lines are as follows:


//The first line contains string .
//The second line contains string .
//Constraints

//and  consist of characters in the range ascii[a - z].
//Output Format


//For each pair of strings, return YES or NO.

//Sample Input

//2
//hello
//world
//hi
//world
//Sample Output


//YES
//NO
//Explanation

//We have pairs to check:

//, . The substrings  and are common to both strings.
//, .  and share no common substrings.

}
