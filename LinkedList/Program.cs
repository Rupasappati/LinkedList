using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Welcome Message
            Console.WriteLine("=-=-=-=-=-Welcome To The Linked List Program-=-=-=-=-=");

            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            //Searching an Element
            linkedList.SearchElement(30);

            /* //Display Data Before Delete Last element 
             Console.WriteLine("-----------------------------------------------");
             Console.WriteLine("Display Data Before Delete Last element ::");
             Console.WriteLine("-----------------------------------------------");
             linkedList.Display();
             //Delete Last Element
             linkedList.PopLastElement();
             //Display Data After Delete Last element 
             Console.WriteLine("-----------------------------------------------");
             Console.WriteLine("Display Data After Delete Last element ::");
             Console.WriteLine("-----------------------------------------------");
            */
            Console.WriteLine("Data In Linked List");
            linkedList.Display();

            Console.ReadLine();

        }
    }
}