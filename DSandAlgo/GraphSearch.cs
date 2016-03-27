using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class GraphSearch
    {

        public static void CallBForDFSearch()
        {

            TreeNode root = PopulateTree();
            //BFSearch(root);
            DFSearch(root);
        }

        public static void DFSearch(TreeNode root)
        {
            if (root == null) return;
            if (root.isVisited == false)
            {
                Console.Write("{0}->", root.val);
                root.isVisited = true;
                //This should be foreach once we finalize the GraphNode
                DFSearch(root.left);
                DFSearch(root.right);
            }
        }


        /// <summary>
        /// this will build below tree
        ///          1
        ///        2 - 3
        ///        |   |
        ///       6-7 4-5 
        /// </summary>
        public static TreeNode PopulateTree()
        {
            TreeNode root = new TreeNode();
            root.val = 1;
            root.isVisited = false;
            root.left = 
            new TreeNode(2,
                 new TreeNode(4,
                 null,
                 null,
                 false),
                 new TreeNode(5,
                 null,
                 null,
                 false),
                 false);
            root.right = new TreeNode(3,
                new TreeNode(6,
                null,
                null,
                false),
                new TreeNode(7,
                null,
                null,
                false), 
                false);
            return root;
        }

        /// <summary>
        /// Breath first search. implementing using treenode - but will extend it for graphnodes
        /// 
        /// </summary>
        /// <param name="root"></param>
        public static void BFSearch(TreeNode root)
        {
            if (root == null) return;
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root);
            while(q.Count!=0)
            {
                TreeNode n = q.Dequeue();
                if(n.isVisited!=true)
                {
                    Console.Write("{0}->", n.val);//visit n
                    n.isVisited = true;
                    //this code to be replaced with foreach when implenenting for graph
                    if (n.left != null)
                        q.Enqueue(n.left);
                    if (n.right != null)
                        q.Enqueue(n.right);
                }
            }

        }
    }
}
