using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSandAlgo
{
   public class List
    {
       static Node head;
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
           a=ReverseLinkedListRec(a);
           a.next = null;
           head.PrintLinkedList();
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

       static Node ReverseLinkedListRec(Node current)
       {
           
           
           if (current.next == null)
           {
               head = current;   
               return head;
           }
           else
           {
               Node tmp = ReverseLinkedListRec(current.next);
               Console.WriteLine("tmp={0}, current={1}, current.next={2}", tmp.val, current.val, current.next.val);
               tmp.next = current;
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
            int count = 0;
            while(head!=null)
            {
                Console.Write(head.val+"->");
                head = head.next;
                if (count++ > 7) break;
            }
            Console.WriteLine();
        }
    }
}
