/* 
Operations:
A, B, C, D, E, F, G
    
Dependencies:
B depends on A
C depends on A
A depends on G
A depends on D
E depends on D
E depends on F
    
Sample Output:
G, D, F, A, E, B, C
6 3 5 0 4 1 2
 * 
 * a=0
 * b=1
 * c=2
 * d=3
 * e=4
 * f=5
 * g=6
*/

/*    
    0,1
  0 A,B  => G,A
  1 A,C  => D,A
  3 G,A  => F,E
  4 D,A  => A,B
  5 D,E  => A,C 
  6 F,E
  
  //algo
  Represent the depenecy in 2XN array
  Fill it up with dependency given
  sort the array based on col. 0
  print col. 0 wihtout dup.
  then print col. 1 with out dup.
 */
using System.Collections.Generic;
using System;
namespace DSandAlgo
{
    public class DependencyOperations
    {

        public static void CallDependencyOperation()
        {
            int LengthOfOperatoin = 7;
            int[] result = new int[LengthOfOperatoin];

            int[,] d = new int[,] 
          {
              {0,1},
              {0,2},
              {6,0},
              {3,0},
              {3,4},
              {5,4}
          };
            //6, 3, 5, 0, 4, 1, 2

            for (int r = 0; r < 6; r++)
            {
                //Check if it is presnt on col=1
                //if present bring it's parent on top
                for (int r1 = r; r1 < 6; r1++)
                {
                    if (d[r, 0] == d[r1, 1])
                    {
                        //Swap with r
                        int t = d[r, 0];
                        int t1 = d[r, 1];
                        d[r, 0] = d[r1, 0];
                        d[r, 1] = d[r1, 1];
                        d[r1, 0] = t;
                        d[r1, 1] = t1;
                        break;

                    }

                }
            }


                HashSet<int> h = new HashSet<int>();
                int r2 = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        if (h.Contains(d[i,0]) == false)
                        {
                            result[r2++] = d[i,0];
                            h.Add(d[i,0]);
                        }
                    }
                    for (int i = 0; i < 6; i++)
                    {
                        if (h.Contains(d[i,1]) == false)
                        {
                            result[r2++] = d[i,1];
                            h.Add(d[i,1]);
                        }
                    }



            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);

            }
            Console.WriteLine();
        }
    } 
}