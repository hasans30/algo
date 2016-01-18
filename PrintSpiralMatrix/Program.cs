using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSpiralMatrix
{
    class Program
    {

        static void Main(string[] args)
        {

            int[,] matrix = CreateMatrx(1, 5);
            PrintMatrix(matrix, 1, 5);
            Console.ReadLine();

        }


        static void PrintMatrix(int [,] matrix,int rowSize,int colSize)
        {
            int state = 1;
            int i = 0, j = 0;
            int endmark=0;
            int brk = 0;
            int nElement = rowSize * colSize;
            while (brk++<nElement)
            {
                Console.Write("[{0},{1}]-{2}", i, j,endmark);
                switch (state)
                {
                    case 1:
                        j++;
                        if(j==colSize-endmark)
                        {
                            state = 2;
                            j--;
                            i++;
                            Console.WriteLine();

                        }
                        break;
                    case 2:
                        i++;
                        if(i==rowSize-endmark)
                        {
                            state = 3;
                            i--;
                            j--;
                            Console.WriteLine();

                        }
                        break;
                    case 3:
                        j--;
                        if(j==endmark-1)
                        {
                            state = 4;
                            j++;
                            i--;
                            endmark++;
                            Console.WriteLine();

                        }
                        break;
                    case 4:
                        i--;
                        if (i == endmark-1)
                        { 
                            state = 1;
                            i++;
                            j++;
                            Console.WriteLine();

                        }
                        break;

                    default:
                        Console.WriteLine("default");
                        break;
                    
                }
            }
            
        }

        static int [,] CreateMatrx(int rowSize, int colSize)
        {
            int [,] matrix = new int[rowSize,colSize];
            int value = 0;
            
            for(int i=0;i<rowSize;i++)
            {
                for(int j=0; j<colSize;j++)
                {
                    matrix[i, j] = value++;

                }
            }

            return matrix;
        }


    }
}
