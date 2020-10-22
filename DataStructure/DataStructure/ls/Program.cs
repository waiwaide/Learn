using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ls
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test the instructions of singlyLinkedList.");
            LinkList<int> linkList = new LinkList<int>();
            Console.WriteLine("Append 0-4 for singlyLinkedList.");
            for (int i = 0; i < 5; i++)
            {
                linkList.Append(i);
            }
           
            Console.WriteLine("Get the length of singlyLinkedList,the value is {0}", linkList.Count());

            Console.WriteLine("Show the singLyLinkedList {0}",linkList.ToString());

            linkList.RemoveAt(3);
           Console.WriteLine("Remove the third element of singLyLinkedList and show the rest {0}",linkList.ToString());
            linkList.Reverse();
            Console.WriteLine("Reverse and show the singLyLinkedList  {0}", linkList.ToString());
            linkList.InsertBefore(6,3);
            
            Console.WriteLine("Insert a 6 before the third element and show {0}", linkList.ToString());
            linkList.InsertAfter(7,3);
            Console.WriteLine("Insert a 7 before the fourth element and show {0}", linkList.ToString());
            Console.WriteLine("Get the secend element and show the value:{0}",linkList.GetItemAt(1));


          Console.ReadKey(); 
            
        }
    }
}
