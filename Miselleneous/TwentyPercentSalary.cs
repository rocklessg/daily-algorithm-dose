using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miselleneous
{
    public static class TwentyPercentSalary
    {
        private const double percentage = 20;
        public static double GetTotalSalary(double twentyPercent) => twentyPercent * 100 / percentage;
    }
}
