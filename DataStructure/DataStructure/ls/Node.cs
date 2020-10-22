using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ls
{
    class Node<T>
    {
        private T data;
        private Node<T> next;

    

        public Node(T val, Node<T> p)
        {
            this.Data = val;
            this.Next = p;
        }

        public Node(Node<T> p)
        {
            this.Next = p;
        }

        public Node(T val)
        {
            this.Data = val;
            this.Next = null;
        }

        public Node()
        {
            this.Data = default(T);
            this.Next = null;
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

        internal Node<T> Next
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
    }
}
