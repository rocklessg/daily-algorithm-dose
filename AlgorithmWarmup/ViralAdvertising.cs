using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class ViralAdvertising
    {
        public static int ViralAdvert(int n)
        {
            // n is the number of days.

            int counter = 0;
            int divisor = 2;
            int multiple = 3;
            int numberOfPeople = 5;

            for (int i = n - 1; i >= 0; i--)
            {
                var liked = numberOfPeople / divisor;
                var shared = liked * multiple;
                counter += liked;
                numberOfPeople = shared;
            }
            return counter;
        }
    }
}
/*
        HackerLand Enterprise is adopting a new viral advertising strategy.
        When they launch a new product, they advertise it to exactly  people
        on social media.

        On the first day, half of those  people (i.e., floor 5 / 2 = 2 ) like the advertisement
        and each shares it with  of their friends. At the beginning of the second day,
        floor (5 / 2) * 3 = 2 * 3 = 6
        people receive the advertisement.

        Each day,  floor (recipient / 2) of the recipients like the advertisement and will share it with
        friends on the following day. Assuming nobody receives the advertisement twice,
        determine how many people have liked the ad by the end of a given day, beginning
        with launch day as day .

        Example
        .

        Day Shared Liked Cumulative
        1      5     2       2
        2      6     3       5
        3      9     4       9
        4     12     6      15
        5     18     9      24
        The progression is shown above. The cumulative number of likes on the  day is .

        Function Description

        Complete the viralAdvertising function in the editor below.

        viralAdvertising has the following parameter(s):

        int n: the day number to report
        Returns

        int: the cumulative likes at that day
        Input Format

        A single integer, , the day number.

        Constraints

        Sample Input

        3
        Sample Output

        9
        Explanation

        This example is depicted in the following diagram:

        strange ad.png

         people liked the advertisement on the first day,  people liked the
        advertisement on the second day and  people liked the advertisement
        on the third day, so the answer is .

 */