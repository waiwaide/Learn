using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SequentialStack
{
    class SeqStack<T> : IStackDS<T>
    {
        private T[] data;
        private int top;

        public SeqStack(int size)
        {
            this.data = new T[size];
            top = -1;
        }

        public SeqStack():this(10)
        {
            this.data = new T[10];
            top = -1;
        }
        public int Count
        {
            get
            {
                return top + 1;
            }
        }

        public void Clear()
        {
            top = -1;
        }

        public int GetLength()
        {
            return Count;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }

        public T Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("当前栈没有元素");
                return default(T);
            }
            return data[top];

        }

        public T Pop()
        {
            T temp = data[top];
            top--;
            return temp;


        }

        public void Push(T item)
        {
            throw new NotImplementedException();
        }
    }
}
