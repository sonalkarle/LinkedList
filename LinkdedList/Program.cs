using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data)
        {
            this.data = data;
            this.next = null;
        }
    }
    class LinkedList
    {
        public Node head;

        public LinkedList()
        {
            head = null;
        }
        public void Display()
        {
            if (head == null)
            {
                Console.WriteLine("Nothing to display");
                return;
            }

            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                if (temp.next != null)
                {
                    Console.Write("->");
                }
                temp = temp.next;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //UC1
            LinkedList staticlinkedList = new LinkedList();
            Node node56 = new Node(56);
            Node node30 = new Node(30);
            Node node70 = new Node(70);
            node56.next = node30;
            node30.next = node70;
            staticlinkedList.head = node56;
            staticlinkedList.Display();


        }
    }
}
    