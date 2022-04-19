using HiredAlgo;
using InterviewPreparationKit;
using InterviewPreparationKit.DictAndHashmap;
using LeetCodeAlgo;
using Miselleneous;
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


            var result = DuplicateRemove.MultipleGame(new int[] { 2, 3, 2, 0, 4 });
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            //var result = DuplicateRemove.RemoveAdjacentDuplicate("aabbaaaccdddaabbbb");
            //Console.WriteLine(result);

            //var result = DuplicateRemove.RemoveDuplicatesChar("aaabbbcccdddeeefffggghhhiiijjjkkkiiilllmmmnnnooopppqqqqqqqrrrrrssssttttuuuvwwxxxxxxyzzABCDEFGHIJKLMNOPQRSTUVWXYZ");
            //Console.WriteLine(result);

            //var result = Assessment.Solution(new long[] { 6, 0, -1, 10 });
            //Console.WriteLine(result);

            //var result = MaxWater.MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            //Console.WriteLine(result);

            //var nums = new List<int> { 10, 5, 20, 20, 4, 5, 2, 1 };
            //var result = UnderHoodOfSortingElements.SortArray(nums);
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}


            //var nums = new List<string> { "Banana", "Higland", "Mango", "Lia", "Campala", "Santana" }.ToArray();
            //var result = ReverseArray.ArrayReverseUnderTheHood(nums);

            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            // the reversed array will be => Santana Campala Lia Mango Higland Banana


            //var nums = new List<int> { 10, 5, 20, 20, 4, 5, 2, 25, 1 };
            //var result = RecordBreaking.BreakingRecords(nums);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //var result = Anagram.SherlockAndAnagrams("mom");
            //Console.WriteLine(result);

            //var val = LaptopRentalChallenge.LaptopRentals(new int[][] { new int[] { 1, 5 }, new int[] { 5, 6 }, new int[] { 6, 7 }, new int[] { 7, 9 } });
            // Console.WriteLine(val);
            // Entry.RunApp();
            // StairCase.StairCCase(6);

            //List<int> myList = new List<int> { 1, 2, 3, 221, 8974 };
            // var result = RotateLeftArray.rotLeft(myList, 4);

            // var nums = new List<int> { 2, 1, 8, 4, 3, 5, 7, 9 };
            // MinimumBribe.MinimumBribes(nums);

            //Console.WriteLine(result);
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
            //
            //var result = Program.Direction(new string[] { "NORTH", "SOUTH", "EAST", "WEST" });

            //var result = MinimumSwap.MinimumSwaps(new int[] { 7, 1, 3, 2, 4, 5, 6 });
            //Console.WriteLine(result);



            //MagazineCheck.CheckMagazine(new List<string> { "two", "times", "three", "is", "not", "four" }, new List<string> { "two", "times", "two", "is", "four" });
            //MagazineCheck.CheckMagazine(new List<string> { "attack", "at", "dawn" }, new List<string> { "Attack", "at", "dawn" });
            // MagazineCheck.CheckMagazine(new List<string> { "apgo", "clm", "w", "lxkvg", "mwz", "elo", "bg", "elo", "lxkvg", "elo", "apgo", "apgo", "w", "elo", "bg" }, 
            // new List<string> { "elo", "lxkvg", "bg", "mwz", "clm", "w" });
        }




        //    function median($numbers)
        //    {
        //        sort($numbers);
        //        $totalNumbers = count($numbers);
        //        $mid = floor($totalNumbers / 2);

        //        return ($totalNumbers % 2) === 0 ? ($numbers[$mid - 1] + $numbers[$mid]) / 2 : $numbers[$mid];
        //    }



    }
}
