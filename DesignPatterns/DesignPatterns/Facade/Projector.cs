using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Facade
{
    class Projector
    {
        private string name;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        internal Projector(string name)
        {
            this.name = name;
        }
        internal void Open()
        {
            Console.WriteLine("打开投影仪");
        }
        internal void Close()
        {
            Console.WriteLine("关闭投影仪");
        }
        internal void SetWideScreen()
        {

            Console.WriteLine("投影仪状态为宽屏模式,{0}",Name);
        }

        internal void SetStandardScreen()
        {

            Console.WriteLine("投影仪状态为标准模式,{0}", Name);

        }
    }
}
