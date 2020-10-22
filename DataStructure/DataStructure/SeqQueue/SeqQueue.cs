using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeqQueue
{
    class SeqQueue<T>:IQueue<T>
    {
        private T[] data;
        private int count; //表示当前有几个元素
        private int front; //队首  （队首索引-1）
        private int rear;  //队尾 （队尾元素索引）
        public SeqQueue(int size)
        {
            data = new T[size];
            count = 0;
            front = -1;
            rear = -1;
        }
        public SeqQueue()
        {
            data = new T[10];
            count = 0;
            front = -1;
            rear = -1;
        }
        public int Count
        {
            get
            {
                return count;
            }
        }
        public void Clear()
        {
            count = 0;
            front = -1;
            rear = -1;
        }
        public T Dequeue()
        {
            if (count > 0)
            {
                T temp = data[front + 1];
                front++;
                count--;
                return temp;
            }
            else
            {
                Console.WriteLine("队列中没有数据，无法取得队首数据");
                return default(T);
            }
        }
        public void Enqueue(T item)
        {
            if (count == data.Length)
            {
                Console.WriteLine("队列元素已满，不可添加");
            }
            else
            {
                if (rear == data.Length - 1) //最后一个位置是否有值
                {
                    data[0] = item;
                    rear = 0;
                    count++;
                }
                else
                {
                    data[rear + 1] = item;
                    rear += 1;
                    count++;
                }
            }
        }
        public int GetLength()
        {
            return count;
        }
        public bool IsEmpty()
        {
            return count == 0;
        }
        public T Peek()
        {
            T temp = data[front + 1];
            return temp;
        }

    }
}
