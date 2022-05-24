using System;
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
            linkedList.Append(56);
            linkedList.Append(30);
            linkedList.Append(70);

            //Display Data of Linked List
            linkedList.Display();

            Console.ReadLine();

        }
    }
}