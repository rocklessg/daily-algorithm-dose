using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miselleneous
{
    public static class DuplicateRemove
    {
        public static string RemoveDuplicate(string str)
        {
            var uniqueCharHolder = String.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                if (!uniqueCharHolder.Contains(str[i]))
                {
                    uniqueCharHolder += str[i];
                }

            }
            return uniqueCharHolder;
        }

        public static string RemoveDuplicatesChar(string input1)
        {
            string result = "";

            foreach (char item in input1)
            {
                if (result.IndexOf(item) == -1)
                {
                    result += item;
                }
            }
            return result;
        }

        public static string RemoveDup(string str)
        {
            string result = string.Empty;

            for (var i = 0; i < str.Length; i++)
            {
                for (int j = i; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        result += str[i];
                    }
                }
            }
            return result;
        }


        public static string RemoveAdjacentDuplicate(string str)
        {
            //Input = aabbaaaccdddaabbbb
            //Output = abacdab
            var temp = str;//Create temporary holder as a copy
            var output = new StringBuilder(str[0].ToString()); // Holder for the first char of the str input
            for (int i = 1; i < str.Length; i++)
            {
                if (str[i] == temp[i - 1]) // check if current char is equals to the adjacent char before it
                    continue; // if true, continue (Do nothing)
                output.Append(str[i]); // else append the current char to the output holder
            }
            return output.ToString();
        }

        //Given an array[2, 5, 3, 6, 4, 8, 3, 7]
        //Write a program to generate a new array
        //Example:
        //input=[2,3,2,1,4]
        //ouput=[24,16,24,48,12]

        public static int[] MultipleGame(int[] input)
        {
            int prod = 1;
            int flag = 0;
            int n = input.Length;

            // product of all elements
            for (int i = 0; i < n; i++)
            {

                // counting number of elements
                // which have value
                // 0
                if (input[i] == 0)
                    flag++;
                else
                    prod *= input[i];
            }

            // creating a new array of size n
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {

                // if number of elements in
                // array with value 0
                // is more than 1 then each
                // value in new array
                // will be equal to 0
                if (flag > 1)
                {
                    arr[i] = 0;
                }

                // if no element having value
                // 0 than we will
                // insert product/a[i] in new array
                else if (flag == 0)
                    arr[i] = (prod / input[i]);

                // if 1 element of array having
                // value 0 then all
                // the elements except that index
                // value , will be
                // equal to 0
                else if (flag == 1 && input[i] != 0)
                {
                    arr[i] = 0;
                }

                else
                    arr[i] = prod;
            }
            return arr;
        }
    }
}
