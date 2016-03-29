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

        //Fahad's solution

        public static void CallFlattenByFahd()
        {
            Node head = new Node(1);
            head.next = new Node(2);
            head.next.down = new Node(4);
            head.next.next = new Node(3);
            head.next.down.down = new Node(6);
            head.next.down.down.next = new Node(5);
            head.next.down.down.next.next = new Node(7);

            /**
             * 1 -> 2
             * |
             * 3
             */
            Flatten(head);

            while (head != null)
            {
                Console.WriteLine("{0}->", head.val);
                head = head.next;
            }
        }

        private static Node Last(Node n)
        {
            if (n == null)
                return null;
            else
            {
                while (n.next != null)
                    n = n.next;
            }

            return n;
        }

        private static void Flatten(Node head)
        {
            Node next = null;
            Node down = null;
            while (head != null)
            {
                if (head.down != null)
                {
                    next = head.next;
                    down = head.down;
                    head.next = head.down;
                    Last(down).next = next;
                }
                head = head.next;
            }
        }



    }
}
