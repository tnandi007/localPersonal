using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class Node
    {
        public Node next = null;
        public int Data;
        public Node(int d)
        {
            Data = d;
        }

        //Add note at the begining
        public Node Push(Node head, int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return head;
            }
            newNode.next = head;
            head = newNode;
            return head;

        }

        //Add Node at the end
        public Node Add(ref Node head, int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return head;
            }

            //Node copy = head;
            //while (head.next != null)
            //{
            //    head = head.next;
            //}
            //head.next = newNode;
            //return copy;
            Node runner = head;
            while (runner.next != null)
            {
                runner = runner.next;
            }
            runner.next = newNode;

            return head;

        }

        //public Node AddTest(ref Node head, int data)
        //{
        //    Node newNode = new Node(data);
        //    if (head == null)
        //    {
        //        head = newNode;
        //        return head;
        //    }

        //    while (head.next != null)
        //    {
        //        head = head.next;
        //    }
        //    head.next = newNode;

        //    return head;

        //}

        //Renove node from any place in a LinkedList
        public Node remove(Node head, int val)
        {
            Node tobeDeleted = head;
            Node prev = null;
            while (tobeDeleted != null)
            {

                if (tobeDeleted.Data == val)
                {
                    if (prev == null)//Means we are deleting the head
                    {
                        head = tobeDeleted.next;
                        break;
                    }
                    //we are deleting any node after head 
                    prev.next = tobeDeleted.next;
                    tobeDeleted = null;
                    break;
                }

                prev = tobeDeleted;

                tobeDeleted = tobeDeleted.next;
            }
            return head;
        }

        public Node removeLastNode(Node head)
        {
            
            if (head == null)
                return null;

            if (head.next == null)
            {
                return null;
            }

            // Find the second last node
            Node second_last = head;
            while (second_last.next.next != null)
                second_last = second_last.next;

            // Change next of second last
            second_last.next = null;

            return head;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Node head = new Node(5);
            //head = head.Push(head, 12);
            //head = head.Push(head, 29);
            //head = head.Push(head, 11);
            //head = head.Push(head, 23);
            //head = head.Push(head, 8);

            //8->23->11->29->12->5->null

            head = head.Add(ref head, 12);
            //head = head.AddTest(ref head, 12);
            head = head.Add(ref head, 29);
            //head = head.AddTest(ref head, 29);
            head = head.Add(ref head, 11);
            head = head.Add(ref head, 23);
            head = head.Add(ref head, 8);

         
            head = head.removeLastNode(head);
            head = head.remove(head, 8);

            
            List<int> storeSum = new List<int>();
            //while(head!=null)
            //{
            //    Node runner = head;
            //    while (runner.next.next!=null)
            //    {
            //        runner = runner.next;
            //    }
            //    storeSum.Add(runner.next.Data + head.Data);
            //    runner.next = null;
            //    head = head.next;
            //}

            //get the sum of first and last node untill we traverse all the inner nodes
            Node current = head;
            while (current != null)
            {
                Node runner = current;
                while (runner.next.next != null)
                {
                    runner = runner.next;
                }
                storeSum.Add(runner.next.Data + current.Data);
                runner.next = null;
                current = current.next;
            }

        }
    }
}
