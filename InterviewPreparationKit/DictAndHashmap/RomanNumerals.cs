using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPreparationKit.DictAndHashmap
{
    public static class RomanNumerals
    {
        public static string CheckNumber(int number)
        {
            var container = string.Empty;
            var dict = new Dictionary<string, int>
            {
                ["I"] = 1,
                ["V"] = 5,
                ["X"] = 10,
                ["L"] = 50,
                ["C"] = 100,
                ["D"] = 500,
                ["M"] = 1000,
            };

            if (number > 3999) return "Number out of range";
            if (number < 0) return "Please enter a positive integer";
            if (number == 0) return null;

            foreach (var item in dict)
            {
                if (number <= 3999)
                {
                    if (item.Value == number)
                    {
                        container = item.Key;
                    }
                    else if (!dict.ContainsValue(number))
                    {
                        return "Number not found";
                    }
                }
            }
            return container;
        }
    }
}
