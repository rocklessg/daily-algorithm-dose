using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankAlgo
{
    public class RecordBreaking
    {
        public static List<int> BreakingRecords(List<int> scores)
        {
            var miniCount = 0;
            var maxiCount = 0;
            var mini = scores[0];
            var maxi = scores[0];
            List<int> container = new List<int>();

            for (var i = 0; i < scores.Count; i++)
            {
                if (scores[i] < mini)
                {
                    mini = scores[i];
                    miniCount += 1;
                }

                if (scores[i] > maxi)
                {
                    maxi = scores[i];
                    maxiCount += 1;
                }
            }
            container.Add(maxiCount);
            container.Add(miniCount);
            return container;
        }
    }
}
