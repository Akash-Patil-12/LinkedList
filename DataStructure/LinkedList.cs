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
        /// Insert at pertiqular position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal Node InsertAtParticularPosition(int position, int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                return newNode;
            }
            if (position == 0)
            {
                newNode.next = this.head;
                this.head = newNode;
                return this.head;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
            return this.head;
        }
        /// <summary>
        /// Remove first node
        /// </summary>
        /// <returns></returns>
        internal void RemoveFirst()
        {
            if (this.head == null)
            {
                Console.WriteLine("list is empty");

            }
            this.head = this.head.next;
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
            Console.WriteLine();
        }
        /// <summary>
        /// Remove list node 
        /// </summary>
        /// <returns></returns>
        internal void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            if (head.next == null)
            {
                Console.WriteLine("list is empty");
            }
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
        }
    }
}
