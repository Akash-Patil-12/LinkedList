using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class SortingList<T> where T :IComparable<T>
    {
        public NodeGeneric<T> head = null;
        public NodeGeneric<T> tail = null;
        public void AddNode(T data)
        {
            NodeGeneric<T> newNode = new NodeGeneric<T>(data);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
            }
        }
        public void SortOrderList()
        {
            NodeGeneric<T> current =head, index = null;
            T temp;
            if (head == null)
            {
                return;
            }
            else
            {
                while (current != null)
                {
                    index = current.next;
                    while (index != null)
                    {
                        if (current.data.CompareTo(index.data) > 0)
                        {
                            temp = current.data;
                            current.data = index.data;
                            index.data = temp;
                        }
                        index = index.next;
                    }
                    current = current.next;
                }
            }
            
        }
       public void Show()
        {
            NodeGeneric<T> current = this.head;
            while (current != null)
            {
                Console.Write(current.data+" ");
                current = current.next;
            }
            Console.WriteLine();
        }
    }
}
