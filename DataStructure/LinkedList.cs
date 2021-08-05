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
        public void Add(int data)
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
        public bool InsertAtParticularPosition(int position, int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                return false;
            }
            if (position == 0)
            {
                newNode.next = this.head;
                this.head = newNode;
                return true;
            }
            Node prev = null;
            Node current = this.head;
            int count = 1;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newNode.next = prev.next;
            prev.next = newNode;
            return true;
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
        /// <summary>
        /// Search specific number is present or not 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Search(int data)
        {
            Node tempHead = this.head;
            while (tempHead != null)
            {
                if (tempHead.data == data)
                {
                    return true;
                }
                tempHead = tempHead.next;
            }
            return false;
        }
        /// <summary>
        /// Find specific number if number present insert data 
        /// </summary>
        /// <param name="searchData"></param>
        /// <param name="insertData"></param>
        /// <returns></returns>
        public bool SearchAndInsert(int searchData,int insertData)
        {
            Node node = new Node(insertData);
            Node previous = null;
            Node tempNode = this.head;
            if (tempNode == null)
            {
                return false;
            }
            while (tempNode != null)
            {
                previous = tempNode.next;
                if (tempNode.data == searchData)
                {
                    tempNode.next = node;
                    node.next = previous;
                    return true;
                }
                tempNode = tempNode.next;
            }
            return false;
        }
    }
}
