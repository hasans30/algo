using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class RotateArrayClass
    {
        static int cost = 0;
        public static void CallRoteateMatrix()
        {
            int[,] A = new int[5, 5] {
                //{1,2,3,4,5},
                //{6,7,8,9,0},
                //{1,2,3,4,5},
                //{6,7,8,9,0},
                //{1,2,3,4,5},

                {1,1,1,1,1},
                {1,1,0,1,1},
                {1,1,1,1,1},
                {1,1,0,1,1},
                {1,1,1,1,1},

            };

            /*
             * 1 6 1 6 1
             * 2 7 2 7 2
             * 3 8 3 8 3
             * 4 9 4 9 4
             * 5 0 5 0 5
             */

            //RotateMatrix(A, 0, 0, 3);

            RotateMatrixHelper(A, 0, 0, 5);

            PrintMatrix(A,5);
            Console.WriteLine(cost);
        }

        private static void RotateMatrixHelper(int[,] A, int sr, int sc, int N)
        {
            if (N < 1) return;
            RotateMatrix(A, sr, sc, N);
            RotateMatrixHelper(A, sr + 1, sc + 1, N - 2);
        }
        private static void PrintMatrix(int[,] A, int N)
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                    Console.Write("{0} ", A[i,j]==1?"x":" ");
                Console.WriteLine();
            }
        }

        public static void RotateMatrix(int[,] A, int sRow, int sCol, int n)
        {

            //Algo :
            // using rotate array logic (reverse first half, reverse second half, then whoe reverse) 
            // Here we have combined columns and rows 

            int eCol = sCol + n - 1;
            //Reverse  first col and last col within themselvs
            for (int i = sRow, j = sRow + n - 1; i < j; i++, j--)
            {
                int t = A[i, sCol];
                A[i, sCol] = A[j, sCol];
                A[j, sCol] = t;

                t = A[i, eCol];
                A[i, eCol] = A[j, eCol];
                A[j, eCol] = t;

                cost++;
            }

            //swap top row and bottom row
            int eRow = sRow + n - 1;
            for (int i = sCol + 1; i < sCol + n - 1; i++)
            {
                int t = A[sRow, i]; ;
                A[sRow, i] = A[eRow, i];
                A[eRow, i] = t;
                cost++;

            }

            //now reverse start row and start col and end row with end col.
            for (int i = sRow; i < eRow; i++)
            {
                int t = A[sRow, i];
                A[sRow, i] = A[i, sCol];
                A[i, sCol] = t;

                t = A[i, eCol];
                A[i, eCol] = A[eRow, i];
                A[eRow, i] = t;
                cost++;

            }


        }
        public static void RotateArray()
        {
            int[] val = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };

            int rightshift = 2;
            int k = val.Length - rightshift;

            Reverse(val, 0, k - 1);
            Reverse(val, k, val.Length - 1);
            Reverse(val, 0, val.Length - 1);

            for (int i = 0; i < val.Length; i++)
            {
                Console.Write("{0},", val[i]);

            }
        }

        public static void Reverse(int[] a, int start, int end)
        {
            for (int i = start, j = end; i < j; i++, j--)
            {
                int t = a[i];
                a[i] = a[j];
                a[j] = t;
            }
        }
    }
}
