using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinkList
{
    class DbLinkList<T>: IListDS<T>
    {
        private DbNode<T> head;
       

        internal DbNode<T> Head
        {
            get
            {
                return head;
            }

            set
            {
                head = value;
            }
        }

        public DbLinkList()
        {
            head = null;
        }

        public T this[int index]
        {
            get
            {
                return this.GetItemAt(index);
            }
        }

        public int Count()
        {
            DbNode<T> p = head;
            int len = 0;
            while(p!=null)
            {
                len++;
                p = p.Next;
            }
            return len;
        }

        public void Clear()
        {
            head = null;
        }
        public bool IsEmpty()
        {
            return head == null;
        }
        public void Append(T item)
        {
            DbNode<T> d = new DbNode<T>(item);
            DbNode<T> n = new DbNode<T>();
            if(head ==null )
            {
                head = d;
                return;
            }
            n = head;
            while (n.Next !=null)
            {
                n = n.Next;
            }
            n.Next = d;
            d.Prev = n;
        }

        public void InsertBefore(T item,int i)
        {
            if(IsEmpty()||i<0)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            if(i==0)
            {
                DbNode<T> q = new DbNode<T>(item);
                q.Next = head;
                q.Prev = head.Prev;
                head.Prev = q;
                head = q;
                
                return;
            }
            DbNode<T> n = head;
            DbNode<T> d = new DbNode<T>();
            int j = 0;
            while (n.Next != null && j<i)
            {
                d = n;
                n = n.Next;
                j++;
            }
            if(n.Next ==null)
            {
                DbNode<T> q = new DbNode<T>(item);
                n.Next = q;
                q.Prev = n;
                q.Next = null;
            }
            else
            {
                if(j==i)
                {
                    DbNode<T> q = new DbNode<T>(item);
                    d.Next = q;
                    q.Prev = d;
                    q.Next = n;
                    n.Prev = q;
                }
            }
        }

        public void InsertAfter(T item,int i)
        {
            if(IsEmpty()||i<0)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            if(i == 0)
            {
                DbNode<T> q = new DbNode<T>(item);
                q.Next = head.Next;
                head.Next.Prev = q;
                head.Next = q;
                q.Prev = head;
                return;
            }
            DbNode<T> p = head;
            int j = 0;
            while (p != null && j < i)
            {
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                DbNode<T> q = new DbNode<T>(item);
                q.Next = p.Next;
                if (p.Next != null)
                {
                    p.Next.Prev = q;
                }
                p.Next = q;
                q.Prev = p;
            }
            else
            {
                Console.WriteLine("Position is error!");
            }

        }

        public T RemoveAt(int i)
        {
            if(IsEmpty()||i<0)
            {
                Console.WriteLine("Link =is empty or Position is error!");
                return default(T);
            }
            DbNode<T> q = new DbNode<T>();
            if (i == 0)
            {
                q = head;
                head = head.Next;
                head.Prev = null;
                return q.Data;
            }
            DbNode<T> p = head;
            int j = 0;
            while(p.Next != null && j<i)
            {
                j++;
                q = p;
                p = p.Next;
            }
            if (j == i)
            {
                p.Next.Prev = q;
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The node is not exist!");
                return default(T);
            }


        }

        public T GetItemAt(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return default(T);
            }
            DbNode<T> p = new DbNode<T>();
            p = head;
            if (i == 0)
            {
                return p.Data;
            }
            int j = 0;
            while(p.Next !=null &&j<i)
            {
                j++;
                p = p.Next;
            }
            if(j == i)
            {
                return p.Data;
            }
            else
            {
                Console.WriteLine("The node is not exist!");
                return default(T);
            }

        }

        public int IndexOf(T value)
        {
            if(IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            DbNode<T> p = new DbNode<T>();
            p = head;
            int i = 0;
            while (!p.Data.Equals(value) && p.Next != null)
            {
                p = p.Next;
                i++;
            }
            return i;
        }

        public void Reverse()
        {
            DbLinkList<T> result = new DbLinkList<T>();
            DbNode<T> t = this.head;
            result.Head = new DbNode<T>(t.Data);
            t = t.Next;
            while(t!=null)
            {
                result.InsertBefore(t.Data, 0);
                t = t.Next;

            }
            this.head = result.head;
            result = null;
        }

        private DbNode<T> GetNodeAt(int i)
        {
            if(IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return null;
            }
            DbNode<T> p = new DbNode<T>();
            p = head;
            if(i == 0)
            {
                return p;
            }
            int j = 0;
            while(p.Next != null && j<i)
            {
                j++;
                p = p.Next;
            }
            if(j == i)
            {

                return p;
            }
            else
            {
                Console.WriteLine("The node is not exist!");
                return null;
            }
        }

        public string TestPrevErgodic()
        {
            DbNode<T> tail = GetNodeAt(Count() - 1);
            StringBuilder sb = new StringBuilder();
            sb.Append(tail.Prev.Data.ToString()+",");
            while (tail.Prev != null)
            {
                sb.Append(tail.Prev.Data.ToString() + ",");
                tail = tail.Prev;
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            DbNode<T> n = this.head;
            sb.Append(n.Data.ToString() + ",");
            while(n.Next != null )
            {
                sb.Append(n.Next.Data.ToString() + ",");
                n = n.Next;
            }
            return sb.ToString();
        }
    }
}
