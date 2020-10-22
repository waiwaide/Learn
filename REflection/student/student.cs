using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace student
{
    public class student
    {
        public student()
        {
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; }
        public string IdCard { get; set; }
        public string Address { get; set; }
        private string Mobile { get; set; }
        public void Eat()
        {
            Console.WriteLine("我今天吃啦好多东西");
        }
        public void Sing()
        {
            Console.WriteLine("耶耶耶耶耶");
        }
        public int Calculate(int a, int b)
        {
            return a + b;
        }
        private string PrivateMethod()
        {
            return "我是一个私有方法";
        }
    
    }
}
