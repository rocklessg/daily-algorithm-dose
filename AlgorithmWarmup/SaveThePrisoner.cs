using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class SaveThePrisoner
    {
        public static int SaveThePrisoners(int prisoners, int candies, int startPoint)
        {
            var result = startPoint + candies - 1;
            var remainder = result % prisoners;
            if (remainder != 0) return remainder;
            return prisoners;
        }
    }
}

/*
                    A jail has a number of prisoners and a number of treats to
                    pass out to them. Their jailer decides the fairest way to
                    divide the treats is to seat the prisoners around a circular
                    table in sequentially numbered chairs. A chair number will be
                    drawn from a hat. Beginning with the prisoner in that chair,
                    one candy will be handed to each prisoner sequentially around
                    the table until all have been distributed.

                    The jailer is playing a little joke, though.
                    The last piece of candy looks like all the others,
                    but it tastes awful. Determine the chair number occupied
                    by the prisoner who will receive that candy.

                    Example

                    There are  prisoners,  pieces of candy and distribution starts at chair .
                    The prisoners arrange themselves in seats numbered  to .
                    Prisoners receive candy at positions . The prisoner to be warned
                    sits in chair number .

                    Function Description

                    Complete the saveThePrisoner function in the editor below.
                    It should return an integer representing the chair number
                    of the prisoner to warn.

                    saveThePrisoner has the following parameter(s):

                    int n: the number of prisoners
                    int m: the number of sweets
                    int s: the chair number to begin passing out sweets from
                    Returns

                    int: the chair number of the prisoner to warn
                    Input Format

                    The first line contains an integer, , the number of test cases.
                    The next  lines each contain  space-separated integers:

                    : the number of prisoners
                    : the number of sweets
                    : the chair number to start passing out treats at
                    Constraints

                    Sample Input 0

                    2
                    5 2 1
                    5 2 2
                    Sample Output 0

                    2
                    3
                    Explanation 0

                    In the first query, there are 5 prisoners and 2 sweets.
                    Distribution starts at seat number 1. Prisoners in seats
                    numbered 1 and 2 get sweets. Warn prisoner 2.

                    In the second query, distribution starts at seat 2
                    so prisoners in seats 2 and 3 get sweets. Warn prisoner 3.

                    Sample Input 1

                    2
                    7 19 2
                    3 7 3
                    Sample Output 1

                    6
                    3
                    Explanation 1

                    In the first test case, there are 7 prisoners, 19 sweets
                    and they are passed out starting at chair 2. The candies
                    go all around twice and there are  more candies passed to
                    each prisoner from seat  to seat .

                    In the second test case, there are 3 prisoners, 7 candies
                    and they are passed out starting at seat 3.
                    They go around twice, and there is one more to pass out to the prisoner at seat 3.

https://www.hackerrank.com/challenges/save-the-prisoner/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign&h_r=next-challenge&h_v=zen
 */
