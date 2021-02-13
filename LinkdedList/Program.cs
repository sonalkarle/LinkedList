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
        public void AddNodeAtStart(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
            Console.WriteLine($"Added {value} at start of the linkedlist");
        }
    }




    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Add Node At Start Demo");
            LinkedList linkedListForStartDemo = new LinkedList();
            linkedListForStartDemo.AddNodeAtStart(70);
            linkedListForStartDemo.AddNodeAtStart(30);
            linkedListForStartDemo.AddNodeAtStart(56);
            linkedListForStartDemo.Display();

        }
    }
}

    