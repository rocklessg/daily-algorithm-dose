using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving
{
    public class MigratoryBirdsAlgorithm
    {

        // This solution needs refactoring
        // This solution passed 4 out of 6 test cases
        public static int migratoryBirds(List<int> arr)
        {
            int freq1 = 1;
            int freq2 = 2;
            int freq3 = 3;
            int freq4 = 4;
            int freq5 = 5;

            int holder1 = 0;
            int holder2 = 0;
            int holder3 = 0;
            int holder4 = 0;
            int holder5 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == freq1)
                {
                    holder1++;
                }
                else if (arr[i] == freq2)
                {
                    holder2++;
                }
                else if (arr[i] == freq3)
                {
                    holder3++;
                }
                else if (arr[i] == freq4)
                {
                    holder4++;
                }
                else if (arr[i] == freq5)
                {
                    holder5++;
                }
            }
            int leastNum = 0;
            if (holder1 > holder2 &&
                holder1 > holder3 &&
                holder1 > holder4 &&
                holder1 > holder5
                )
            {
                leastNum += freq1;
            }
            else if (holder2 > holder1 &&
                holder2 > holder3 &&
                holder2 > holder4 &&
                holder2 > holder5
                )
            {
                leastNum += freq2;
            }
            else if (holder3 > holder1 &&
                holder3 > holder2 &&
                holder3 > holder4 &&
                holder3 > holder5
                )
            {
                leastNum = freq3;
            }
            else if (holder4 > holder1 &&
                holder4 > holder2 &&
                holder4 > holder3 &&
                holder4 > holder5
                )
            {
                leastNum += freq4;
            }
            else if (holder5 > holder1 &&
                holder5 > holder2 &&
                holder5 > holder3 &&
                holder5 > holder4
                )
            {
                leastNum += freq5;
            }
            return leastNum;

        }
    }

//    Given an array of bird sightings where every element represents a bird type id,
//    determine the id of the most frequently sighted type.If more than 1 type has been
//    spotted that maximum amount, return the smallest of their ids.

//    Example

//    There are two each of types and, and one sighting of type.Pick the lower of the
//    two types seen twice: type.

//    Function Description
    

//    Complete the migratoryBirds function in the editor below.

//    migratoryBirds has the following parameter(s):


//    int arr[n]: the types of birds sighted
//    Returns
    

//    int: the lowest type id of the most frequently sighted birds
//    Input Format
    

//    The first line contains an integer, , the size of.
//    The second line describes  as  space-separated integers, each a type number
//    of the bird sighted.


//    Constraints

//    It is guaranteed that each type is , , , , or.
//    Sample Input 0

//6
//1 4 4 4 5 3
//Sample Output 0

//4
//Explanation 0


//    The different types of birds occur in the following frequencies:


//    Type :  bird
//    Type :  birds
//    Type :  bird
//    Type :  birds
//    Type :  bird
//    The type number that occurs at the highest frequency is type , so we print  as our answer.


//    Sample Input 1

//11
//1 2 3 4 5 4 3 2 1 3 4
//Sample Output 1

//3
//Explanation 1


//    The different types of birds occur in the following frequencies:


//    Type : 
//Type : 
//Type : 
//Type : 
//Type : 
//Two types have a frequency of, and the lower of those is type.

}
