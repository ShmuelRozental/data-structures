using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node<T>
    {
        T Value;
        Node<T> Next;

        public T GetValue()
        {
            return Value;
        }
        public Node<T> GetNext()
        {
            return Next;
        }

        public void SetValue(T value)
        {
            this.Value = value;
        }
        public void SetNext(Node<T> next)
        {
            Next = next;
        }

        public Node(T value)
        {
            this.Value = value;
        }
    }


    internal class LinkedList<T>
    {
        private Node<T> Head;

        public LinkedList()
        {
            this.Head = null;
        }

        public LinkedList(T data)
        {
            Head = new Node<T>(data);
        }

        public void Add(Node<T> newNode) {
            {
                Node<T> current = Head;
                if (current == null)
                {
                    Head = newNode;
                }
                else
                {
                    while (current.GetNext != null)
                    {
                        current = current.GetNext();
                    }
                    current.SetNext(newNode);
                }
            }

        }

        public void Display()
        {
            if (Head == null)
            {
                return;
            }

            Node<T> current = Head;
            string result = "";

            while (current != null)
            {
                result += current.GetValue().ToString();
                if (current.GetNext() != null)
                {
                    result += " -> ";
                }
                current = current.GetNext();
            }

            return result;
        }

        public void Remove(Node<T> node) 
        {



    }
}
