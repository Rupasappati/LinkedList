﻿using System;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {

            //Welcome Message
            Console.WriteLine("\n");
            Console.WriteLine("=-=-=-=-=-Welcome To The Linked List Program-=-=-=-=-=");
            Console.WriteLine("\n");


            //Calling Class LinkedList
            LinkedList linkedList = new LinkedList();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);

            Console.ReadLine();
        }
    }
}