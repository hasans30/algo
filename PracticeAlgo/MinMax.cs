using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem

Given an array of integers, find the maximum and minimum of the array.

Constraint

Find the answer in minimum number of comparisons
see more http://www.dsalgo.com/2013/02/FindMinMax.php.html
*/

namespace PracticeAlgo
{
    partial class Program
    {
        static void MinMax(string[] args)
        {
            int[] a = { 4, 3, 5, 1, 2, 6, 9, 10, 11 };
            //int[] a = { 4, 4, 4, 4, 4, 4, 4, 4, 4 };
            //int[] a = { 1, 2, 3, 4, 5, 6, 9, 10, 11 };
            int min, max;
            min = a[0];
            max = a[0];
            int i ;
            int count = 0;
            for(i=0;i<a.Length/2;i++)
            {

                count++;

                if (a[i*2]>=a[i*2+1])
                {

                    min = min > a[i*2 + 1] ? a[i*2 + 1] : min;
                    count++;


                    max = max < a[i*2] ? a[i*2] : max;
                    count++;

                }
                else
                {

                    min = min > a[i*2] ? a[i *2] : min;
                    count++;

                    max = max < a[i*2+1] ? a[i*2+1] : max;
                    count++;

                }

            }

            if (i * 2 < a.Length)
            {
                int num = a[i * 2];
                if (max < num)
                    max = num;
                if (min > num)
                    min = num;
                count += 2;
            }

            Console.WriteLine("min={0} max={1}: count = {2}", min, max, count);
        }
    }
}
