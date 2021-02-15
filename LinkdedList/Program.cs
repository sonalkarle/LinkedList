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

        public void AddNodeAtEnd(int value)
        {
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
        public void AddNodeAfterNode(int nodeValue, int addAfterThisValue)
        {
            Node newNode = new Node(nodeValue);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node temp = head;
                while (temp.data != addAfterThisValue)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;

            }
            Console.WriteLine($"Added {nodeValue} at in between");
        }






        class Program
        {


            static void Main(string[] args)

            {
                Console.WriteLine("Add Node After Node ");
                LinkedList linkedListForNodeAfterNode = new LinkedList();
                linkedListForNodeAfterNode.AddNodeAtEnd(56);
                linkedListForNodeAfterNode.AddNodeAtEnd(30);
                linkedListForNodeAfterNode.AddNodeAtEnd(70);
                linkedListForNodeAfterNode.AddNodeAfterNode(40, 30);
                linkedListForNodeAfterNode.Display();
            }
        }
    }
}
                     
