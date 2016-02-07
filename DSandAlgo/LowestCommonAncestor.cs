using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class LowestCommonAncestor
    {

        public static void CallLCAHelper()
        {
            TreeNode parRoot = PopulateTree();
            /*
             *                 10        
             *            -2 (root)   
             *      2 (a)         4(b)
             *   -1 (c) 3(e)        5(d)
             *          -4(f)
            */
            //BuildBinaryTreeFromInAndPre.PrintTree(parRoot, 0);
            TreeNode tn=LCAHelper(parRoot, 3,-1,0);
            //Console.WriteLine(tn.val);

        }

        public static TreeNode PopulateTree()
        {
            TreeNode parRoot = new TreeNode(); parRoot.val = 10;
            TreeNode root = new TreeNode(); root.val = -2; parRoot.left = root;
            TreeNode a = new TreeNode(); a.val = 2; root.left = a;
            TreeNode b = new TreeNode(); b.val = 4; root.right = null; parRoot.right = b;
            TreeNode c = new TreeNode(); c.val = -1; a.left = c; c.left = c.right = null;
            TreeNode d = new TreeNode(); d.val = 5; b.right = d; b.left = null;
            TreeNode e = new TreeNode(); e.val = 3; a.right = e; e.right = null;
            TreeNode f = new TreeNode(); f.val = -4; e.left = f; f.left = null; f.right = null;
            return parRoot;
        }
        public static TreeNode LCAHelper(TreeNode tn, int p, int q, int deep)
        {
            Console.WriteLine(tn.val + ":" + deep);
            if (tn == null) { return null; }
            if (tn.val == p || tn.val == q)
            {
                return tn;
            }
            bool is_p_on_left = Covers(tn.left, p);
            bool is_q_on_left = Covers(tn.left, q);

            if (is_p_on_left != is_q_on_left) {  return tn; }

            TreeNode childside = is_p_on_left == true ? tn.left : tn.right;
            return LCAHelper(childside, p, q, deep+1);
            
        }



        public static bool Covers(TreeNode n, int key)
        {
            if (n == null) return false;
            if (n.val == key) return true;
            return (Covers(n.left, key) || Covers(n.right, key));
        }


    }
}
