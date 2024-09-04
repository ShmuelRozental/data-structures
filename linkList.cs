//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace LinkedLists
//{
//    internal class linkList<T>
//    {
//        private Node<T> Head;

//        public linkList()
//        {
//            Head = null;
//        }

//        public linkList(T data)
//        {
//            Head = new Node<T>(data);
//        }

//        public void Add(T data) {
//            Node<T> newNode = new Node<T>(data);
//            if (Head == null)
//                Head = newNode;
//            else {
//                Node<T> current = Head;
//                while (current.Next != null) 
//                {
//                    current = current.Next;
//                }


