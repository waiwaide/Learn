using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeqQueue
{
    interface IQueue<T>
    {
        int Count { get; }
        int GetLength();
        bool IsEmpty();
        void Clear();
        void Enqueue(T item);
        T Dequeue();
        T Peek();
    

}
}
