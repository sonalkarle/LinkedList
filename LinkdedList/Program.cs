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

    public class LinkedList

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

        public bool Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    Console.WriteLine("Data Found");
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }






        class Program
        {


            static void Main(string[] args)

            {
                //UC7
                LinkedList staticlinkedList = new LinkedList();

                Console.WriteLine("Search for Node 30");
                staticlinkedList.Display();
                if (staticlinkedList.Search(30))
                {
                    Console.WriteLine("Node found");
                }

            }
        }
    }
}
                     
