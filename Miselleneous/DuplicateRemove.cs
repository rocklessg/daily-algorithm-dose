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
            string table = "";

            string result = "";
            foreach (char item in input1)
            {
                if (table.IndexOf(item) == -1)
                {
                    table += item;
                    result += item;
                }
            }
            return result;
        }
    }

}
