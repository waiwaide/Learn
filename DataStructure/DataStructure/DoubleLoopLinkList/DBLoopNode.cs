using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoubleLoopLinkList
{
    class DBLoopNode<T>
    {
        private T data;
        private DBLoopNode<T> prev;
        private DBLoopNode<T> next;

        internal DBLoopNode<T> Next
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

        internal DBLoopNode<T> Prev
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

        public DBLoopNode(T data, DBLoopNode<T> next, DBLoopNode<T> prev)
        {
            this.Data = data;
            this.Next = next;
            this.Prev = prev;
        }
        public DBLoopNode(T data, DBLoopNode<T> next)
        {
            this.Data = data;
            this.Next = next;
            this.Prev = null;
        }
        public DBLoopNode(DBLoopNode<T> next)
        {
            this.Data = default(T);
            this.Next = next;
            this.Prev = null;
        }

        public DBLoopNode(T data)
        {
            this.Data = data;
            this.Next = null;
            this.Prev = null;

        }
        public DBLoopNode()
        {
            this.Data = default(T);
            this.Next = null;
            this.Prev = null;
        }
    }
}
