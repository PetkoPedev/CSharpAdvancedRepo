using System;

namespace _07WorkshopExersise
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DoublyLinkedList list = new DoublyLinkedList();

            list.AddFirst(5);
            list.AddFirst(45);
            list.AddLast(46);
            list.AddFirst(32);
            list.AddFirst(87);
            list.AddLast(38);
            list.AddFirst(56);
            list.AddFirst(67);
            list.AddFirst(90);
            list.RemoveFirst();
            list.RemoveLast();
            int number = list.Count;
            list.ForEach(x => Console.WriteLine(x));
            Console.WriteLine(number);
        }
    }
}
