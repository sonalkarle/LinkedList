using System;
using System.Collections.Generic;
using System.Text;

namespace Linklistassignment
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

        public Node(int data, Node next) : this(data)
        {
            this.next = next;
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
        public void DeleteNodeAtFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("Nothing to delete");
                return;
            }

            Node temp = this.head;
            this.head = this.head.next;

            Console.WriteLine("Removed from linkedlist :" + temp.data);
        }

    }




    class Program
    {
        
        static void Main(string[] args)

        {
            /// UC2: Adding new values in linked list
            LinkedList linkedListForBetweenDemo = new LinkedList();

            Console.WriteLine("Delete First element demo");
            linkedListForBetweenDemo.Display();
            linkedListForBetweenDemo.DeleteNodeAtFirst();
           
            linkedListForBetweenDemo.Display();
        }
    }
}
