using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Welcome Message
            Console.WriteLine("=-=-=-=-=-Welcome To The Linked List Program-=-=-=-=-=");
            Console.WriteLine("-----------------------------------------------");

            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            //Searching an Element            
            linkedList.SearchElement(30);

            //Adding Data After 30
            linkedList.InsertAtParticularPosition(3, 40);

            /* //Display Data Before Delete Last element 
             Console.WriteLine("-----------------------------------------------");
             Console.WriteLine("Display Data Before Delete Last element ::");
             Console.WriteLine("-----------------------------------------------");
             linkedList.Display();
             //Delete Last Element
             linkedList.PopLastElement();
            */

            //Display Data After Add
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Display After Adding element ::");
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Data In Linked List");
            linkedList.Display();

            //Delete element and then get size
            linkedList.Delete(40);

            //Display Data After Add
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Display After Delete element ::");
            Console.WriteLine("Size of Linked List : " + linkedList.Size());
            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Data In Linked List");
            linkedList.Display();


            Console.ReadLine();

        }
    }
}