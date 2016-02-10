using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{

    /*
     * consider below linked list - now flatten it as 10 > 2 > -6 > -7 > 8 > 3 > 5
     *  10 -> 2 -> 3 -> 5
     *        |
     *        v
     *        -6->8
     *        |
     *        V
     *        -7
     *   note : below implementation uses Queue. Try without using Queue and iterative way.
     */
    class FlattenLinkedListClass
    {
        public static void CallFlattenLinkedList()
        {
            TreeNode tn = LowestCommonAncestor.PopulateTree();
            BuildBinaryTreeFromInAndPre.PrintTree(tn, 0);
            Queue<TreeNode> Q = new Queue<TreeNode>();
            FlattenLinkedList(tn,Q);
            TreeNode tmp1=Q.Dequeue();
            TreeNode tmp = tmp1;
            while(Q.Count>0)
            {
                tmp.right=Q.Dequeue();
                tmp = tmp.right;
            }
            tmp.right = null;

            while(tmp1!=null)
            {
                Console.Write("{0}->", tmp1.val);
                tmp1 = tmp1.right;
            }
            Console.WriteLine();
        }

        public static void FlattenLinkedList(TreeNode current, Queue<TreeNode> store)
        {
            if (current == null) return;
            store.Enqueue(current);
            FlattenLinkedList(current.left,store);
            FlattenLinkedList(current.right,store);
        }


    }
}
