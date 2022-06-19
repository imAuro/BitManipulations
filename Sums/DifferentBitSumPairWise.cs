using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitManipulations.Sums
{
    class DifferentBitSumPairWise
    {
        /// <summary>
        /// TC: O(n2) SC : O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int cntBits(List<int> A)
        {
            int res = 0;
            int count = 0;
            for (int i = 0; i < A.Count; i++)
            {
                for (int j = i + 1; j < A.Count; j++)
                {
                    res = A[i] ^ A[j];
                    while (res > 0)
                    {
                        if ((res & 1) == 1) count++;
                        res=res >> 1;
                    }
                }
            }
            return count * 2;
        }

        /// <summary>
        /// TC: O(n) SC: O(1)
        /// </summary>
        /// <param name="A"></param>
        /// <returns></returns>
        public int cntBits2(List<int> A)
        {
            long sum = 0;
            long ones = 0;
            long zeros = 0;
            for (int i = 0; i < 32; i++)
            {
                ones = 0;
                zeros = 0;
                for (int j = 0; j < A.Count; j++)
                {
                    if (((A[j]) & (1 << i)) > 0) ones++;
                    else zeros++;

                }
                sum = sum + 2 * ones * zeros;
                sum = sum % 1000000007;
            }
            return (int)sum;

        }


    }
}
