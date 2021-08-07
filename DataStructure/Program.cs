using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingList<int> list = new SortingList<int>();
            list.AddNode(56);
            list.AddNode(30);
            list.AddNode(40);
            list.AddNode(70);
            Console.WriteLine("Before Sort list is :");
            list.Show();
            list.SortOrderList();
            Console.WriteLine("After Sort list is :");
            list.Show();
        }
    }
}
