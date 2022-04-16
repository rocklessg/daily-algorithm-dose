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
    }

}
