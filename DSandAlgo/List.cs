using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSandAlgo
{
   public class List
    {
       public static void ListReversal()
       {
           Node a = new Node(); a.val = 3;
           Node b = new Node(); b.val = 2;
           Node c = new Node(); c.val = 4;
           Node d = new Node(); d.val = 1;
           Node e = new Node(); e.val = 5;
           a.next = b;
           b.next = c;
           c.next = d;
           d.next = e;
           e.next = null;
           a.PrintLinkedList();
           a=ReverseLinkedList(a);
           a.PrintLinkedList();
       }

       static Node ReverseLinkedList(Node head)
       {
                Node prev=null;
                Node next=null;
                while (head != null)
               {
                   next = head.next;
                   head.next = prev;
                   prev = head;
                   head = next;
               }
               return prev;
           
       }

       static Node ReverseLinkedListRec(Node current, Node prev)
       {
           
           if (current.next == null)
           {
               return current;
           }
           else
           {
               current = ReverseLinkedListRec(current.next, current);
               current.next = prev;
               return current;
           }
       }
    }

    class Node
    {
        public int val;
        public Node next;
        public void PrintLinkedList()
        {
            Node head = this;
            while(head!=null)
            {
                Console.Write(head.val+"->");
                head = head.next;
            }
            Console.WriteLine();
        }
    }
}
