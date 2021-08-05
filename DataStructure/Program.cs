using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(70);
            list.InsertAtParticularPosition(1, 30);
            Console.Write("List is :");
            list.ShowList();
        }
    }
}
