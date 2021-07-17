using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Yakovlev_Tree
{
    class Node<T>
    {
        private T info;
        private Node<T> link;

        public T Info
        {
            get { return info; }
            set { info = value; }
        }

        public Node<T> Link
        {
            get { return link; }
            set { link = value; }
        }

        public Node() { }

        public Node(T info)
        {
            Info = info;
        }

        public Node(T info, Node<T> link)
        {
            Info = info;
            Link = link;
        }
    }
}
