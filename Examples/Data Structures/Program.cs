using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakingNodes
{
    class Node
    {
        public string Data
        {
            get; set;
        }
        public Node Next { get; set; }
    }
    class LinkedListNode
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Count { get; set; }

        public void Add(string userInput)
        {
            Node newNode = new Node { Next = null, Data = userInput };
            if (Count == 0)
            {
                Head = newNode;
                Tail = newNode;
                Count++;
            }
            else
            {
                //Change the tail next reference
                Tail.Next = newNode;
                //change the tail
                Tail = newNode;
                Count++;
            }
        }
        public Node GetNode(int index)
        {
            int start = 0;
            Node temp = Head; //mark the start of my search
            while (start != index)
            {
                start += 1;
                temp = temp.Next;
            }
            return temp; //once found, return the node, else return null
        }

        public void PrintList()
        {
            for (int i = 0; i < Count; i++)
            {
                Console.WriteLine(GetNode(i).Data);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            LinkedListNode myList = new LinkedListNode();
            myList.Add("Steve");
            myList.Add("Mauricio");
            myList.Add("Evan");
            myList.Add("Dan");

            Console.WriteLine("my list's count is " + myList.Count);

            Console.WriteLine();

            myList.PrintList();

            Node tempNode = myList.GetNode(3);
            tempNode.Data = "Ty";

            Console.WriteLine();
            myList.PrintList();

        }
    }
}


