using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.AddFirst(70);
            list.AddFirst(30);
            list.AddFirst(56);
            Console.Write("List is :");
            list.ShowList();
        }
    }
}
