using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class CompressString
    {
        public static void Compress()
        {
            char[] a = new char[] { 'a', 'b', 'c', 'd',' '};
            char c = a[0];
            int count = 0,j=0;
            for(int i=0;i<a.Length;i++)
            {
                if (a[i] == c) count++;
                else if(a[i]!=c||(i==a.Length))
                {
                    Console.WriteLine(j);
                    a[j] = c;
                    c = a[i];
                    a[j+1] = String.Format("{0}",count).ToCharArray()[0];
                    j = j + 2;

                    //above line bug to be fixed
                   
                    count = 1;
                }
            }
            Console.WriteLine(new string(a));
        }
    }
}
