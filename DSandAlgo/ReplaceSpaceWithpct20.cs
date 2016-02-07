using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class ReplaceSpaceWithpct20
    {
        public static void ReplaceWith20()
        {
            char[] a = "hi how are you#           ".ToArray();
            int i=0, newEnd=0, j=0, spaceCnt=0;
            for(i=0;a[i]!='#';i++)
            {
                if (a[i] == ' ') spaceCnt++;
            }

            newEnd = i + spaceCnt * 2;
            j = newEnd;
            
            if (newEnd > a.Length)
            {
                Console.WriteLine("insufficient capacity");
                return;
            }
            a[j] = '#';
           
            while(i>=0)
            {
                if( a[i]==' ')
                {
                    a[j] = '0';
                    a[--j] = '2';
                    a[--j] = '%';
                }
                else
                    a[j] = a[i];
                j--; i--;
            }

            for (i = 0; i < newEnd; i++)
                Console.Write(a[i]);
            Console.WriteLine();

        }
    }
}
