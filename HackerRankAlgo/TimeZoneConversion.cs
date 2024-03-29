﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class TimeZoneConversion
    {
        public static string TimeConversion(string s)
        {
            //first solution
            return DateTime.Parse(s).ToString("HH:mm:ss");
            //==========    

        }
    }

    //public class WholeMinuteDilemma
    //{
    //    public int numPairsDivisibleBy60(List<int> songs)
    //    {
    //        var map = new Dictionary<int, int>();
    //        int count = 0;
    //        foreach (int s in songs)
    //        {
    //            if (map.ContainsKey(((60 - s % 60)) % 60))
    //            {
    //                count += map.Append((60 - s % 60) % 60);
    //            }
    //            map.Add(s % 60, map.GetValueOrDefault(s % 60, 0) + 1);
    //        }
    //        return count;
    //    }

    //}
    //Given a time in -hour AM/PM format, convert it to military(24-hour) time.

    //Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
    //- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.

    //Example

    //Return '12:01:00'.

    //Return '00:01:00'.

    //Function Description


    //Complete the timeConversion function in the editor below.It should 
    //    return a new string representing the input time in 24 hour format.

    //timeConversion has the following parameter(s):


    //string s: a time in hour format
    //Returns


    //string: the time in hour format
    //Input Format


    //A single string that represents a time in -hour clock format (i.e.:  or ).

    //Constraints

    //All input times are valid
    //Sample Input 0

    //07:05:45PM
    //Sample Output 0

    //19:05:45
}
