using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructure
{
    interface IListDS<T>
    {
        int GetLength();
        void Insert(T item, int i);
        void Add(T item);
        bool IsEmpty();
        bool IsFull();
        T GetElement(int i);
        void Delete(int i);
        void Clear();
        int LocateElement(T item);
        void Reverse();
    }
}
