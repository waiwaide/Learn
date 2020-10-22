using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTree
{
    interface ILinkBinaryTree<T>
    {
        bool IsEmpty();
        Node<T> GetRoot();
        Node<T> GetLeftChild(Node<T> node);
        Node<T> GetRightChild(Node<T> node);
        void InsertLeftNode(T data,Node<T> node);
        void InsertRightNode(T data, Node<T> node);

        void DeleteLeftNode(Node<T> node);
        void DeleteRightNode(Node<T> node);

        bool IsLeaf(Node<T> node);
        
        
    }
}
