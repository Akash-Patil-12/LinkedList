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
            list.Add(60);
            Console.Write("List is :");
            list.ShowList();
            if (list.Search(30))
                Console.WriteLine("Number present");
            else
                Console.WriteLine("Number not present");
        }
    }
}
