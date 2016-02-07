using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class MaxSubSum
    {
        public static void CalculateMaxSubSum()
        {
            int[] a = { 5, -1, -2, -3, 6, 5,-1 };
            int maxStart = 0;
            int maxEnd = 0;
            int maxSum=-1;
            int currentSum = 0;
            int i = 0, j = i;
            for(j=i;j<a.Length;j++)
            {
                currentSum += a[j];
                if(currentSum>maxSum)
                {
                    maxSum = currentSum;
                    maxStart = i;
                    maxEnd = j;
                }
                if (currentSum < 0)
                {
                    currentSum = 0;
                    i = j + 1;
                }
            }

            Console.WriteLine("{0}-{1}", maxStart, maxEnd);
            for (i = maxStart; i <= maxEnd; i++)
                Console.WriteLine(a[i]);

        }
    }
}
