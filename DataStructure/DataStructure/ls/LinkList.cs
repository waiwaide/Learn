using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ls
{
    class LinkList<T> : IListDS<T>
    {
        private Node<T>  head;

        internal Node<T> Head
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
        public LinkList()
        {
            head = null;
        }

        /// <summary>
        /// 类索引器
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T this[int index]
        {
            get
            {
                return this.GetItemAt(index);
            }
        }
        /// <summary>
        /// 返回单链表的长度
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            Node<T> p = head;
            int len = 0;
            while (p != null)
            {
                len++;
                p = p.Next;
            }
            return len;
        }
        /// <summary>
        /// 清空
        /// </summary>
        public void Clear()
        {
            head = null;
        }
        /// <summary>
        /// 是否为空
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return head == null;
        }
        /// <summary>
        /// 在最后附加元素
        /// </summary>
        /// <param name="item"></param>
        public void Append(T item)
        {
            Node<T> d = new Node<T>(item);
            Node<T> n = new Node<T>();
            if (head == null)
            {
                head = d;
                return;
            }
            n = head;
            while (n.Next != null)
            {
                n = n.Next;
            }
            n.Next = d;
        }
        //前插
        public void InsertBefore(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            //在最开头插入
            if (i == 0)
            {
                Node<T> q = new Node<T>(item);
                q.Next = Head;//把"头"改成第二个元素
                head = q;//把自己设置为"头"
                return;
            }
            Node<T> n = head;
            Node<T> d = new Node<T>();
            int j = 0;
            //找到位置i的前一个元素d
            while (n != null && j < i)
            {
                d = n;
                n = n.Next;
                j++;
            }
            if (n == null) //说明是在最后节点插入(即追加)
            {
                Node<T> q = new Node<T>(item);
                n.Next = q;
                q.Next = null;
            }
            else
            {
                if (j == i)
                {
                    Node<T> q = new Node<T>(item);
                    d.Next = q;
                    q.Next = n;
                }
            }
        }
        /// <summary>
        /// 在位置i后插入元素item
        /// </summary>
        /// <param name="item"></param>
        /// <param name="i"></param>
        public void InsertAfter(T item, int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("List is empty or Position is error!");
                return;
            }
            if (i == 0)
            {
                Node<T> q = new Node<T>(item);
                q.Next = head.Next;
                head.Next = q;
                return;
            }
            Node<T> p = head;
            int j = 0;
            while (p != null && j < i)
            {
                p = p.Next;
                j++;
            }
            if (j == i)
            {
                Node<T> q = new Node<T>(item);
                q.Next = p.Next;
                p.Next = q;
            }
            else
            {
                Console.WriteLine("Position is error!");
            }
        }
        /// <summary>
        /// 删除位置i的元素
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T RemoveAt(int i)
        {
            if (IsEmpty() || i < 0)
            {
                Console.WriteLine("Link is empty or Position is error!");
                return default(T);
            }
            Node<T> q = new Node<T>();
            if (i == 0)
            {
                q = head;
                head = head.Next;
                return q.Data;
            }
            Node<T> p = head;
            int j = 0;
            while (p.Next != null && j < i)
            {
                j++;
                q = p;
                p = p.Next;
            }
            if (j == i)
            {
                q.Next = p.Next;
                return p.Data;
            }
            else
            {
                Console.WriteLine("The node is not exist!");
                return default(T);
            }
        }
        /// <summary>
        /// 获取指定位置的元素
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public T GetItemAt(int i)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty!");
                return default(T);
            }
            Node<T> p = new Node<T>();
            p = head;
            if (i == 0)
            {
                return p.Data;
            }
            int j = 0;
            while (p.Next != null && j < i)
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
        //按元素值查找索引
        public int IndexOf(T value)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is Empty!");
                return -1;
            }
            Node<T> p = new Node<T>();
            p = head;
            int i = 0;
            while (!p.Data.Equals(value) && p.Next != null)
            {
                p = p.Next;
                i++;
            }
            return i;
        }
        /// <summary>
        /// 元素反转
        /// </summary>
        public void Reverse()
        {
            LinkList<T> result = new LinkList<T>();
            Node<T> t = this.head;
            result.Head = new Node<T>(t.Data);
            t = t.Next;
            //(把当前链接的元素从head开始遍历，逐个插入到另一个空链表中，这样得到的新链表正好元素顺序跟原链表是相反的)
            while (t != null)
            {
                result.InsertBefore(t.Data, 0);
                t = t.Next;
            }
            this.head = result.head;//将原链表直接挂到"反转后的链表"上
            result = null;//显式清空原链表的引用，以便让GC能直接回收
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node<T> n = this.head;
            sb.Append(n.Data.ToString() + ",");
            while (n.Next != null)
            {
                sb.Append(n.Next.Data.ToString() + ",");
                n = n.Next;
            }
            return sb.ToString().TrimEnd(',');
        }

    }
}
