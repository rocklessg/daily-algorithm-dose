using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
        public static class LaptopRentalChallenge
        {
            public static int LaptopRentals(int[][] times)
            {
                var lTimes = times.Select(l => l.ToList()).ToList();
                if (lTimes[0].Count == 0)
                {
                    return 0;
                }
                int usedLaptops = 0;
                List<int> startTimes = new List<int>();
                List<int> endTimes = new List<int>();
                foreach (var interval in times)
                {
                    startTimes.Add(interval[0]);
                    endTimes.Add((interval[1]));
                }
                startTimes.Sort();
                endTimes.Sort();
                int startIterator = 0;
                int endIterator = 0;
                while (startIterator < lTimes.Count)
                {
                    if (startTimes[startIterator] >= endTimes[endIterator])
                    {
                        usedLaptops -= 1;
                        endIterator += 1;
                    }
                    usedLaptops += 1;
                    startIterator += 1;
                }
                return usedLaptops;
            }
    }


       
        //You're given a list of time intervals during which students at a school need a laptop. 
        //These time intervals are represented by pairs of integers [start, end], where 0 <= start < end. However, 
        //start and end don't represent real times; therefore, they may be greater than 24.

        //No two students can use a laptop at the same time, but immediately after a student is 
        //done using a laptop, another student can use that same laptop.For example, if one student 
        //rents a laptop during the time interval[0, 2], another student can rent the same laptop during 
        //any time interval starting with 2.

        //Write a function that returns the minimum number of laptops that the school 
        //needs to rent such that all students will always have access to a laptop when they need one.

        //Challenge.LaptopRentals(times)
        //Parameters
        //times: Array<int[]> - A 2D array containing the times the student would require a laptop.

        //Return Value
        //int - Minimum number of laptops the school needs to rent.

        //Examples
        //times   Return Value
        //[[0,2], [1,4], [4,6], [0,4], [7,8], [9,11], [3,10]]	3
        //[[0,4],[2,3],[2,3],[2,3]]	4
        //[[1,5],[5,6],[6,7],[7,9]]

    }



