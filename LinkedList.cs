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

        public string Display()
        {
            if (Head == null)
            {
                return"";
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


        public int Length()
        {
            int count = 0;
            Node<T> current = Head;

            while (current != null)
            {
                count++;
                current = current.GetNext();
            }

            return count;
        }



        public void RemoveIndex(int index)
         {
            if (index < 0 || Head == null)
                throw new ArgumentOutOfRangeException("Index out of range or list is empty.");

            if (index == 0)
            {
                Head = Head.GetNext(); 
                return;
            }

            Node<T> current = Head;
            for (int i = 0; i < index - 1; i++)
            {
                if (current.GetNext() == null)
                    throw new ArgumentOutOfRangeException("Index out of range.");
                current = current.GetNext();
            }

            Node<T> nodeToRemove = current.GetNext();
            if (nodeToRemove != null)
                current.SetNext(nodeToRemove.GetNext());
        }


        public void RemoveValue(T data)
        {
            if (Head == null)
                return; 

            if (Head.GetValue().Equals(data))
            {
                Head = Head.GetNext();
                return;
            }

            Node<T> current = Head;
            while (current.GetNext() != null)
            {
          
                if (current.GetNext().GetValue().Equals(data))
                {
                    current.SetNext(current.GetNext().GetNext());
                    return; 
                }
                current = current.GetNext();
            }
        }

        public void RemoveAllValues(T data)
        {
            while (Head != null && Head.GetValue().Equals(data))
            {
                Head = Head.GetNext();
            }

        
            if (Head == null)
                return;

            Node<T> current = Head;

           
            while (current.GetNext() != null)
            {
                if (current.GetNext().GetValue().Equals(data))
                {
                    current.SetNext(current.GetNext().GetNext());
                }
                else
                {
                    current = current.GetNext();
                }
            }
        }

        public int Find(T data)
            {
                Node<T> current = Head;
                int index = 0;

                while (current != null)
                {
                    if (current.GetValue().Equals(data))
                        return index;
                    current = current.GetNext();
                    index++;
                }

                return -1;
            }
        public T Get(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is negative.");
            }

            Node<T> current = Head;
            int currentIndex = 0;

            while (current != null)
            {
                if (currentIndex == index)
                {
                    return current.GetValue();
                }
                current = current.GetNext();
                currentIndex++;
            }

            throw new ArgumentOutOfRangeException(nameof(index), "Index out of range.");
        }




    }
}
