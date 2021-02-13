using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAssignment
{
    public class Node
    {
        /// <summary>
        /// Node class create to intialised the storing location and new location
        /// </summary>
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
        /// <summary>
        /// Linkedlise class created to intialised node position
        /// </summary>
        public Node head;

        public LinkedList()
        {
            head = null;
        }
        public void Display()
        {
            /// Diplay the stored values
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
        public void AddNodeAtEnd(int value)
        {
            /*Add to  End used to display the
             result from end */
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;

            }
            Console.WriteLine($"Added {value} at end of the linkedlist");
        }

    }




    class Program
    {
        static void Main(string[] args)

        {
            /// UC2: Adding new values in linked list

            Console.WriteLine("Add Node At Start Demo");
            LinkedList linkedListForStartDemo = new LinkedList();
            linkedListForStartDemo.AddNodeAtEnd(70);
            linkedListForStartDemo.AddNodeAtEnd(30);
            linkedListForStartDemo.AddNodeAtEnd(56);
            linkedListForStartDemo.Display();

        }
    }
}
