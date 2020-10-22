using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLoopLinkList
{
    class Program
    {
        static void Main(string[] args)
        {
            DBLoopLinkList<int> dBLoopLinkList = new DBLoopLinkList<int>();
            for (int i = 0; i < 5; i++)
            {
                dBLoopLinkList.Append(i);
            }
            Console.WriteLine("Shwo the DBLoopLinkList,{0}", dBLoopLinkList.ToString());

            Console.WriteLine("Show the count of the DBLoopLinkList,{0}", dBLoopLinkList.Count());
            Console.WriteLine("Show the third element of the DBLoopLinkList,{0}", dBLoopLinkList.GetItemAt(2).ToString());
            Console.WriteLine("Show the location of Num 4,the value is {0}", dBLoopLinkList.IndexOf(4));
            Console.WriteLine("Delete the third element {0} and show the rest,{1}", dBLoopLinkList.RemoveAt(2), dBLoopLinkList.ToString());
           
            dBLoopLinkList.Reverse();
              Console.WriteLine("Reverse and show the DbLinkList,{0}", dBLoopLinkList.ToString());
            dBLoopLinkList.InsertBefore(7, 2);
            Console.WriteLine("Insert a 7 before the third element of the DBLoopLinkList and show,{0}", dBLoopLinkList.ToString());
         



            Console.ReadKey();
                
        }
    }

  
}
