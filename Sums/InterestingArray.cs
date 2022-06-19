using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulations.Sums
{
    class InterestingArray
    {
        /// <summary>
        /// TC:O(n) SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public string solve(List<int> A)
        {
            int oddCount = 0;
            foreach (var item in A)
            {
                if (item % 2 != 0) oddCount++;

            }
            if (oddCount % 2 == 0) return "Yes";
            return "No";
        }
    }
}
