using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class SocksParing
    {
        public static int SockMerchant(int n, List<int> ar)
        {

            HashSet<int> unmatched = new HashSet<int>();
            int pairs = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                if (!unmatched.Add(ar[i]))
                {
                    unmatched.Remove(ar[i]);
                    pairs++;
                }
            }
            return pairs;

            //    int constantNumber = 0;
            //    int counter = 0;
            //    int pairCounter = 0;


            //    for (int i = 1; i < ar.Count - 1; i++)
            //    {
            //        if (ar[i] >= constantNumber)
            //        {
            //            counter++;

            //            if (counter % 2 == 0)
            //            {
            //                int holder = counter / 2;

            //                pairCounter += holder;

            //                counter = 1;
            //                constantNumber = ar[i];
            //            }
            //            else if (counter - 1 > 0)
            //            {
            //                int holder = (counter - 1) / 2;
            //                pairCounter += holder;
            //                counter = 1;
            //                constantNumber = ar[i];
            //            }
            //        }
            //    }
            //    return pairCounter;
            //}

        }
    }
// There is a large pile of socks that must be paired by color.Given an array of 
// integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

//Example


//There is one pair of color  and one of color.There are three odd socks left, one of each color. The number of pairs is .

//Function Description

//Complete the sockMerchant function in the editor below.

//sockMerchant has the following parameter(s):

//int n: the number of socks in the pile
//int ar[n]: the colors of each sock
//Returns

//int: the number of pairs
//Input Format

//The first line contains an integer, the number of socks represented in .
//The second line contains  space-separated integers, , the colors of the socks in the pile.

//Constraints

// where
//Sample Input

//STDIN Function
//-----                       --------
//9                           n = 9
//10 20 20 10 10 30 50 10 20  ar = [10, 20, 20, 10, 10, 30, 50, 10, 20]
//Sample Output

//3
//Explanation

//sock.png
//
}
