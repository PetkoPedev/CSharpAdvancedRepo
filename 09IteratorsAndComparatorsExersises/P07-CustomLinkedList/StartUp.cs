using System;

namespace P07_CustomLinkedList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var doublyLinkedList = new CustomLinkedList<string>();

            doublyLinkedList.AddLast("string");
            doublyLinkedList.AddLast("1234");
            doublyLinkedList.AddLast("flsf;dl");

            foreach (var item in doublyLinkedList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
