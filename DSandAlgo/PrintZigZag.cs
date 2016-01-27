using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSandAlgo
{
    class PrintZigZag
    {
        public static void printZigzag(Node root) {
  List queue = new List();
  Stack stack = new Stack();
  if (root == null)
   return;
  Node marker = new Node(-1);
  boolean printOrder = true;
  queue.add(root);
  queue.add(marker);
  while (!queue.isEmpty()) {
   Node node = queue.poll();
   if (node == marker) {
    if (!printOrder) {
     while (stack.size() > 0) {
      Node printNode = stack.pop();
      System.out.println(printNode.value);

     }

    }
    printOrder = !printOrder;
    if (!queue.isEmpty())
     queue.add(marker);
    continue;
   }
   if (printOrder) {
    System.out.println(node.value);
   } else {
    stack.push(node);
   }
   if (node.left != null)
    queue.add(node.left);
   if (node.right != null)
    queue.add(node.right);

  }

 }

    }
}
