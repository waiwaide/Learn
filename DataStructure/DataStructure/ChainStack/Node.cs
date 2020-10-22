using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainStack
{
    class Node<T>
    {
        private T data;
        private Node<T> next;

        public Node()
        {
            this.data = default(T);
            this.next = null;
        }
        public Node(T data)
        {
            this.data = data;
            this.next = null;
        }
        public Node(T data, Node<T> index)
        {
            this.data = data;
            this.next = index;
        }
        public Node(Node<T> index)
        {
            data = default(T);
            next = index;
        }
        public T Data
        {
            get { return data; }
            set { data = value; }
        }
        public Node<T> Next
        {
            get { return next; }
            set { next = value; }
        }

    }
}
