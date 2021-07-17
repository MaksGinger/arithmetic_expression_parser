using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Yakovlev_Tree
{
    class NodeStack<T>
    {
        private Node<T> head;

        public NodeStack()
        {
            head = new Node<T>();
            head.Link = head;
        }

        public void Push(T elem)
        {
            Node<T> p = new Node<T>(elem);
            p.Link = head.Link;
            head.Link = p;
        }

        public T Pop()
        {
            if (head.Link != head)
            {
                Node<T> elem = head.Link;
                head.Link = head.Link.Link;
                return elem.Info;
            }
            else return default;
        }

        public T Peek()
        {
            if (head.Link != head) return head.Link.Info;
            else return default;
        }
    }
}
