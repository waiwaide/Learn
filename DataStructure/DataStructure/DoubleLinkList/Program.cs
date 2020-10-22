using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            DbLinkList<int> dbLinkList = new DbLinkList<int>();
            Console.WriteLine("Test the DbLinkList.");
            Console.WriteLine("Add 0-4 to the DbLinkList.");
            for (int i = 0; i < 5; i++)
            {
                dbLinkList.Append(i);
            }
            Console.WriteLine("Show the DbLinkList,{0}", dbLinkList.ToString());
            dbLinkList.Clear();
           
            for (int i = 0; i < 5; i++)
            {
                dbLinkList.Append(i);
            }
            Console.WriteLine("Get the length of singlyLinkedList,the value is {0}", dbLinkList.Count());
            dbLinkList.Reverse();
            Console.WriteLine("Reverse and show the DbLinkList,{0}", dbLinkList.ToString());
        
            dbLinkList.RemoveAt(3);
            Console.WriteLine("Remove the fourth element of the DbLinkList and show,{0}", dbLinkList.ToString());

            dbLinkList.InsertAfter(6,2);
            Console.WriteLine("Insert a 6 after the third element of the DbLinkList and show,{0}", dbLinkList.ToString());

            dbLinkList.InsertBefore(7, 2);
            Console.WriteLine("Insert a 7 before the third element of the DbLinkList and show,{0}", dbLinkList.ToString());

            Console.WriteLine("Get the third element of the DbLinkList and show,{0}", dbLinkList.GetItemAt(2).ToString());
            Console.ReadKey();



    
    }
    }
}
