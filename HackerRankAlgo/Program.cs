using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace HackerRankAlgo
{
    class Program
    {
        public static void Main(string[] args)
        {

            var val = LaptopRentalChallenge.LaptopRentals(new int[][] { new int[] { 1, 5 }, new int[] { 5, 6 }, new int[] { 6, 7 }, new int[] { 7, 9 } });
            Console.WriteLine(val);
            // Entry.RunApp();
            // StairCase.StairCCase(6);

            //List<int> myList = new List<int> { 7, 69, 2, 221, 8974 };

            //MinMax.MiniMaxSum(myList);

            //foreach (var item in myList)
            //{
            //    Console.Write(item);
            //}

            //List<int> myList = new List<int> { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3 };
            //Console.WriteLine(SocksParing.SockMerchant(10, myList));

            //var results = GradingSystem.GradingStudents(myList);
            //foreach (var result in results)
            //{
            //    Console.WriteLine(result);
            //}



            //for (int i = 0; i < 2; i++)
            //{
            //    for (int j = i; j < 4; j++)
            //        Console.WriteLine("Value of i: {0}, J: {1} ", i, j);
            //}
            //var answer = TimeZoneConversion.TimeConversion("07:05:45PM");
            //Console.WriteLine(answer);

        }

    }
}
