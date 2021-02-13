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
        public void DeleteNodeAtLast()
        {
            if (this.head == null)
            {
                Console.WriteLine("Nothing To Delete");
                return;
            }
            Node temp = head;
            while (temp.next.next != null)
            {
                temp = temp.next;
            }
            temp.next = null;
        }





        class Program
        {

                 static void Main(string[] args)

                 {
                  /// UC2: Adding new values in linked list
                     LinkedList linkedListForEndDemo = new LinkedList();

                     Console.WriteLine("Delete Last element demo");
                     linkedListForEndDemo.Display();
                     linkedListForEndDemo.DeleteNodeAtLast();

                      linkedListForEndDemo.Display();

        }        } 
    }
}
