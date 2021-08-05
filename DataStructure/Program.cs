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
            list.Add(70);
            Console.Write("List is :");
            list.ShowList();
            if (list.SearchAndInsert(30,40))
                Console.WriteLine("Number Inserted");
            else
                Console.WriteLine("Number not Inserted");
            Console.Write("After insertion List is :");
            list.ShowList();
        }
    }
}
