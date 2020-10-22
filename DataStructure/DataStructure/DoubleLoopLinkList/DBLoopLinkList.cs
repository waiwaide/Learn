using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLoopLinkList
{
    class DBLoopLinkList<T> : IListDS<T>
    {
        private DBLoopNode<T> head;

        internal DBLoopNode<T> Head
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

        public DBLoopLinkList()
        {
            head = null;
        }

        public T this[int index]
        {
            get
            {
                return GetItemAt(index);
            }
        }
        public void Append(T item)
        {
            DBLoopNode<T> d = new DBLoopNode<T>(item);
            DBLoopNode<T> n = new DBLoopNode<T>();
            if (this.IsEmpty())
            {
                this.head = d;
                this.head.Prev = this.head;
                this.head.Next = this.head;
                return;
            }

            n = this.head;
            while (n.Next != this.head)
            {
                n = n.Next;
            }
            
            d.Prev = n;
            d.Next = this.head;
            this.head.Prev = d;
            n.Next = d;


        }

        public void Clear()
        {
            
            this.head = null;
        }

        public int Count()
        {
            DBLoopNode<T> p = this.head;
            int len = 0;
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return len;
            }
            len++;
            while (p.Next!=this.head)
            {
                len++;
                p = p.Next;
            }
            return len;
        }

        public T GetItemAt(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return default(T);
            }

            DBLoopNode<T> p = this.head;
          
            if (i == 0)
            {
                return p.Data;
            }
            int j = 0;
            while (p.Next != this.head && j < i)
            {
                j++;
                p = p.Next;
            }
            if (j == i)
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
            bool being = false;
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            DBLoopNode<T> p = new DBLoopNode<T>();
            p = head;
            int i = 1;
            while (!p.Data.Equals(value) && p.Next != this.head)
            {
                p = p.Next;
                i++;
            }
            if (p.Data.Equals(value))
            {
                being = true;
            }
            if (!being)
            {
                if (p.Next.Data.Equals(value))
                {
                    being = true;
                    i++;
                }
            }
            return i=being==true?i:-1;
        }

        public void InsertAfter(T item, int i)
        {
            throw new NotImplementedException();
        }

        public void InsertBefore(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            DBLoopNode<T> q = new DBLoopNode<T>(item);
            DBLoopNode<T> m = new DBLoopNode<T>();
            if (i == 0)
            {
                q.Prev = this.head.Prev;               
                q.Next = this.head;

                this.head.Prev.Next = q;
                this.head.Prev = q;               
                this.head = q;
                return;
            }

            DBLoopNode<T> n = head;
            int j = 0;
            while(n.Next !=this.head&&j<i)
            {
                n = n.Next;
                j++;
            }
            
            if (j == i)
            {
                DBLoopNode<T> p = n.Prev;
                p.Next = q;
                q.Prev = p;
                q.Next = n;
                n.Prev = q;
            }
            else
            {
                q.Next = this.head;
                q.Prev = n;
                n.Next = q;
            }
            
           
            


        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public T RemoveAt(int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("Link is empty or Position is error!");
                return default(T);
            }
            DBLoopNode<T> p = new DBLoopNode<T>();
            
           
            if (i == 0)
            {
                p = head;
                head = head.Next;
                head.Prev = p.Prev;
                return p.Data;
            }
            DBLoopNode<T> n = head;
            int j = 0;
            while (p.Next != this.head && j < i)
            {
                j++;
                p = n;
                n = n.Next;
            }

            if (j == i)
            {
                n.Next.Prev = p;
                p.Next = n.Next;
                return n.Data;
            }
            else
            {
                Console.WriteLine("The node is not exist!");
                return default(T);
            }



        }

        public void Reverse()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Link is empty!");
                return;
            }

            DBLoopLinkList<T> d = new DBLoopLinkList<T>();
            DBLoopNode<T> n = this.head;
            DBLoopNode<T> m = this.head;
            d.head = new DBLoopNode<T>(n.Data);
            d.head.Prev = d.head;
            d.head.Next = d.head;
           
            while (n.Next != this.head)
            {
                d.InsertBefore(n.Next.Data,0);
                n = n.Next;
            }
            this.head = d.head;
          
           
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            DBLoopNode<T> n = this.head;
            sb.Append(n.Data.ToString() + ",");
            while (n.Next != this.head)
            {
                sb.Append(n.Next.Data.ToString() + ",");
                n = n.Next;
            }
            return sb.ToString().TrimEnd(',');
        }
    }
}
