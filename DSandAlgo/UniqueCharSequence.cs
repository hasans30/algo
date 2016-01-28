using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class UniqueCharSequence
    {
        static public void UCSequence()
        {
            int si = 0, ei = 0, ms = 0, me = 0, ml = 0, cl = 0;
            string str = "";
            HashSet<char> h = new HashSet<char>();
            for (ei = 0; ei < str.Length; ei++)
            {
                if (!h.Contains(str[ei]))
                {
                    h.Add(str[ei]);
                    cl = ei - si + 1;
                    if (cl > ml)
                    {
                        ms = si;
                        me = ei;
                        ml = cl;
                    }

                }
                else
                {
                    si = ei;
                    //empty the hashset
                    h.Clear();
                    //add si
                    h.Add(str[si]);

                }

            }
            Console.WriteLine("{0},{1}", ms, me);
            for (int i = ms; i <= me; i++)
                Console.Write(str[i]);
        }
    }
}
