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
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        /// <summary>
        /// Add new data at first position
        /// </summary>
        /// <param name="data"></param>
        internal void AddFirst(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp =this.head;
                head = node;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted at first position in list", node.data);
        }
        /// <summary>
        /// Show list all data
        /// </summary>
        internal void ShowList()
        {
            Node temp = this.head;
            while (temp != null)
            {
                Console.Write(temp.data+" ");
                temp = temp.next;
            }
        }
        
    }
}
