﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkQueue
{
    class Node<T>
    {
        private T data;
        private Node<T> next;
        public Node(T data)
        {
            this.data = data;
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
