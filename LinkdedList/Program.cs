using System;
using System.Collections.Generic;
using System.Text;

namespace Linklistassignment
{
    class SortedLinkedList
    {
        public Node head;

        public SortedLinkedList()
        {
            head = null;
        }

        private void AddNodeAtStart(int value)
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
        }
        public void AddNode(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
                return;
            }
            if (value < head.data)
            {
                AddNodeAtStart(value);
                return;
            }
            Node temp = head;
            while (temp.next.data < value)
            {
                temp = temp.next;
                if (temp.next == null)
                {
                    break;
                }
            }
            if (temp.next == null)
            {
                AddNodeAtEnd(value);
            }
            else
            {
                newNode.next = temp.next;
                temp.next = newNode;
            }

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
            Console.WriteLine();

        }
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


            public void DeleteNodeWithValue(int value)
            {
                if (head == null)
                {
                    Console.WriteLine("Nothing to delete");
                }
                Node prev = this.head;
                Node pointsToValue = this.head;
                while (pointsToValue.data != value)
                {
                    if (pointsToValue == null)
                    {
                        break;
                    }
                    pointsToValue = pointsToValue.next;
                }
                while (prev.next.data != value)
                {
                    if (prev == null)
                    {
                        break;
                    }
                    prev = prev.next;
                }
                prev.next = pointsToValue.next;

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
                    Console.WriteLine("Sorted linked list");
                    SortedLinkedList sortedLinkedList = new SortedLinkedList();
                    sortedLinkedList.AddNode(56);
                    sortedLinkedList.AddNode(30);
                    sortedLinkedList.AddNode(40);
                    sortedLinkedList.AddNode(70);
                    sortedLinkedList.Display();
                }
            }
        }
    }
}
                     
