using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个顺序表
            //规定了顺序表的大小，表中存放的int型数据
            SequenceList<int> sequenceList = new SequenceList<int>(3);
            //增加一个
            sequenceList.Add(1);
            //增加一个
            sequenceList.Add(2);
            //增加一个
            sequenceList.Add(3);
            //增加一个,此时超过了顺序表最大值
            sequenceList.Add(4);
            //删除第三个
            sequenceList.Delete(2);
            //在位置三插入一个
            sequenceList.Insert(10,1);
            //倒置
            sequenceList.Reverse();
            //
            Console.WriteLine("{0},{1},{2}", sequenceList[0], sequenceList[1], sequenceList[2]);
            Console.ReadKey();
        }
    }
}
