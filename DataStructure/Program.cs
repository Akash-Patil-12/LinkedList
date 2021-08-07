using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(40);
            list.Add(70);
            Console.WriteLine("Linked list before delete");
            list.ShowList();
            list.SearchAndDelete(40);
            Console.WriteLine("Linked list After delete");
            list.ShowList();
        }
    }
}
