using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    class Node<T>
    {
        private T data;
        private Node<T> lchild;
        private Node<T> rchild;

        public Node(T data, Node<T> lc, Node<T> rc)
        {
            this.Data = data;
            this.Lchild = lc;
            this.Rchild = rc;
        }
        public Node( Node<T> lc, Node<T> rc)
        {
            this.Data = default(T);
            this.Lchild = lc;
            this.Rchild = rc;
        }
        public Node(T data)
        {
            this.Data = data;
            this.Lchild = null;
            this.Rchild = null;

        }
        public Node()
        {
            this.Data = default(T);
            this.Lchild = null;
            this.Rchild = null;
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

        internal Node<T> Lchild
        {
            get
            {
                return lchild;
            }

            set
            {
                lchild = value;
            }
        }

        internal Node<T> Rchild
        {
            get
            {
                return rchild;
            }

            set
            {
                rchild = value;
            }
        }
    }
}
