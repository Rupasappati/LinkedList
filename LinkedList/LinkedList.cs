using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        //Instance
        internal Node head;

        //Appending Data to LinkedList
        internal void Add(int data)
        {
            //Object of Node
            Node node = new Node(data);

            //Add Data
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }
        //Adding Data In Particular Position
        public void InsertAtParticularPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }

        //Delete First element 
        internal Node PopFirstElement()
        {
            if (this.head == null)
                return null;
            this.head = this.head.next;
            return this.head;
        }

        //Delete Last Element
        internal Node PopLastElement()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node newNode = head;
            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            newNode.next = null;
            return head;
        }

        //Search an Element
        public bool SearchElement(int value)
        {
            int index = 0;
            Node temp = head;
            while (temp != null)
            {
                index++;
                if (temp.data.Equals(value))
                {
                    Console.WriteLine(value + " is Found At Index = " + index);
                    return true;
                }
                temp = temp.next;
            }
            return false;
        }

        //Display LinkedList Data through Method
        internal void Display()
        {
            //Head is Null then List is empty otherwise print All data of Linked List
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine("Data : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}