using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class TreeSiblingPointers
    {
        public static void CallTreeSiblingPointers()
        {
            TreeNode root = GraphSearch.PopulateTree();
            AddSibling(root);
            PrintSiblingWise(root);

            Console.WriteLine();

        }

        public static void PrintSiblingWise(TreeNode root)
        {
            if (root == null) return;
           //print siblings
            TreeNode current = root;
            while(current!=null)
            {
                Console.Write("{0}->",current.val);
                current = current.sibling;
            }
            Console.WriteLine();
            PrintSiblingWise(root.left);
        }

        public static void AddSibling(TreeNode root)
        {
            if (root == null) return;
            Queue<TreeNode> q = new Queue<TreeNode>();
            TreeNode special = new TreeNode();
            special.val = Int32.MinValue;
            q.Enqueue(root);
            q.Enqueue(special);
            TreeNode prev = null; 
            while(q.Count!=1)
            {
                TreeNode current = q.Dequeue();
                if (current.val != special.val)
                {
                    //this code to be replaced with foreach when implenenting for graph
                    if (current.left != null)
                        q.Enqueue(current.left);
                    if (current.right != null)
                        q.Enqueue(current.right);
                    if(prev!=null)
                    {
                        prev.sibling = current;
                    }
                    prev = current;

                }
                else
                {
                    q.Enqueue(special);
                    prev = null;
                }
            }
            Console.WriteLine("done");
        }
    }
}
