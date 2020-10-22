using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLinkList
{
    class DbNode<T>
    {
        private T data;
        private DbNode<T> prev;
        private DbNode<T> next;

        internal DbNode<T> Next
        {
            get
            {
                return next;
            }

            set
            {
                next = value;
            }
        }

        internal DbNode<T> Prev
        {
            get
            {
                return prev;
            }

            set
            {
                prev = value;
            }
        }

        public T Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public DbNode(T data, DbNode<T> next, DbNode<T> prev)
        {
            this.Data = data;
            this.Next = next;
            this.Prev = prev;
        }
        public DbNode(T data ,DbNode<T> next)
        {
            this.Data = data;
            this.Next = next;
            this.Prev = null;
        }
        public DbNode(DbNode<T> next)
        {
            this.Data = default(T);
            this.Next = next;
            this.Prev = null;
        }

        public DbNode(T data)
        {
            this.Data = data;
            this.Next = null;
            this.Prev = null;

        }
        public DbNode()
        {
            this.Data = default(T);
            this.Next = null;
            this.Prev = null;
        }

       
    }
}
