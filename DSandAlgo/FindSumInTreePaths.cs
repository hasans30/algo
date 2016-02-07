using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class FindSumInTreePaths
    {
        static int sum = 9;

        public static void CallFindSum()
        {
            TreeNode tn= LowestCommonAncestor.PopulateTree();
            int [] path = new int [100]; //bug - unnecessary memory allocation
            FindSum(tn,0, path );
        }
        static void FindSum(TreeNode tn, int level, int [] path)
        {
            if (tn == null) return;

            path[level] = tn.val;
            int j = 0;
            for (int i = level; i >= 0; i--) //Basically we are checking for a path ends 0 if we have found the sum
            {
                j = path[i] + j;
                if (j == sum)
                {
                    for (j = level; j >= i;j-- ) //if found then going from node till that parent and printing it.
                        Console.Write(path[j] + ">>");
                }
            }
            Console.WriteLine();
            
            FindSum(tn.left, level + 1, path);
            


            FindSum(tn.right, level + 1, path);

            

        }
    }
}
