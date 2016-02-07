using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class Combinition
    {
        public static void CombiHelper()
        {
            char[] a = { 'a', 'b', 'c' };
            char [] res = new  char [5];
            CombinationCalculation(a, a.Length, 2,0,0, res);

        }

        public static void CombinationCalculation(char [] a, int n, int k, int start, int level, char [] res)
        {
            if (k  == level)
            {
                for (int i = 0; i <=k-1; i++)
                {
                    Console.Write("{0}", res[i]);
                }
                Console.WriteLine();
                return;
            }
            for(int i=start;i<n;i++)
            {
                res[level] = a[i];
                CombinationCalculation(a, n, k,i+1, level + 1, res);
            }
        }
    }
}
