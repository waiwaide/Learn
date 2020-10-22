using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    class SequenceList<T> : IListDS<T>
    {
        private int maxSize;//最大容量
        private readonly T[] items;//使用数组存放元素
        private int pointerLast;//始终指向最后一个元素
        public SequenceList(int size)
        {
            this.maxSize = size;
            this.items = new T[size];
            this.pointerLast = -1;
        }
        public T this[int i]
        {
            get
            {
                return this.items[i];
            }

          
        }

        public void Add(T item)
        {
            if (this.IsFull())
            {
                Console.WriteLine("This linear list is full! Can't add any new items！");
            }
            else
            {
                this.items[++this.pointerLast] = item;
            }
        }

        public void Clear()
        {
            this.pointerLast = -1;
        }

  
        public void Delete(int i)
        {
            if (this.pointerLast == -1)
            {
                Console.WriteLine("there are no elements in this linear list!");
                
            }
            if (i > this.pointerLast || i < 0)
            {
                Console.WriteLine("Deleting location is wrong!");
              
            }
            for (int j = i; j < this.pointerLast; j++)
            {
                this.items[j] = this.items[j + 1];
            }
            this.pointerLast--;

        }

        public T GetElement(int i)
        {
            if (this.pointerLast == -1)
            {
                Console.WriteLine("there are no elements in this linear list!");
                return default(T);
            }
            if (i > this.pointerLast || i < 0)
            {
                Console.WriteLine("Exceed the capability!");
                return default(T);
            }
            return this.items[i];
        }

     
        public int GetLength()
        {
            return this.pointerLast + 1;
        }

  
        public void Insert(T item, int i)
        {
            if (i < 1 || i > this.pointerLast + 1)
            {
                Console.WriteLine("The inserting location is wrong!");
                return;
            }
            if (this.IsFull())
            {
                Console.WriteLine("This linear list is full! Can't insert anynew items!");
                return;
                
            }
            this.pointerLast++;
            for (int j = this.pointerLast; j >= j + 1; j--)
            {
                this.items[j] = this.items[j - 1];
            }
            this.items[i] = item;
        }

        public bool IsEmpty()
        {
            return this.pointerLast == -1;
        }

        public bool IsFull()
        {
            return this.pointerLast + 1 == this.maxSize;
        }

        public int LocateElement(T item)
        {
            if (this.pointerLast == -1)
            {
                Console.WriteLine("Thers are no items in the list");
            }
            for (int i = 0; i <= this.pointerLast; i++)
            {
                if (this.items[i].Equals(item))//若是自定义类型，则T类必须把Equals函数override
                {
                    return i;
                }
            }
            Console.WriteLine("Not found");
            return -1;  
        }

    
        public void Reverse()
        {
            if (this.pointerLast == -1)
            {
                Console.WriteLine("There are no items in the list!");
            }
            else
            {
                int i = 0;
                int j = this.GetLength() / 2;//结果为下界整数，正好用于循环
                while (i < j)
                {
                    T tmp = this.items[i];
                    this.items[i] = this.items[this.pointerLast - i];
                    this.items[this.pointerLast - i] = tmp;
                    i++;
                }
            }

        }


    }
}
