using System;
using System.Collections.Generic;

namespace Programlink
{
    class Linklist
    {
        static public void Main()
        {
            //Create Linked list
            LinkedList<int> my_list = new LinkedList<int>();


            //Add element in linked list

            my_list.AddLast(56);
            my_list.AddLast(30);
            my_list.AddLast(70);

            Console.WriteLine("Number as follows");
            //Access the element
            foreach(int num in my_list)
            {
                Console.WriteLine(num);
            }
        }
    }
}
