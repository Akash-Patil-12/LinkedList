using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
   public class LinkedList
    {
        internal Node head;
        /// <summary>
        /// Add new data into linked list
        /// </summary>
        /// <param name="data"></param>
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                 //   Console.WriteLine("Node :" + temp.data);
                    temp = temp.next;
                }
                temp.next = node;

            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        
    }
}
