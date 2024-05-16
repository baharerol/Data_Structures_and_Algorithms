using LinkedList.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Doubly
{
    public class DoublyLinkedList<T> : IDoublyLinkedList<T>, IEnumerable<T>
    {
        public DoublyLinkedListNode<T>? Head { get; set; }
        public DoublyLinkedListNode<T>? Tail { get; set; }

        private bool isHeadNull { get; set; }

        public DoublyLinkedList()
        {
            this.isHeadNull = true;
        }

        public DoublyLinkedList(IEnumerable<T> collection)
        {
            isHeadNull = true;
            foreach (var item in collection)
            {
                AddLast(item);
            }
        }

        public void AddFirst(T item)
        {
            var node = new DoublyLinkedListNode<T>(item);
            if (isHeadNull)
            {
                Head = node;
                Tail = node; // Tail = Head;
                isHeadNull = false;
                return;  
            }

            Head.Prev = node;
            node.Next = Head;
            Head = node;
        }

        public void AddLast(T item)
        {
            var node = new DoublyLinkedListNode<T>(item);
            if (isHeadNull)
            {
                Head = node;
                Tail = node; // Tail = Head;
                isHeadNull = false;
                return; 
            }

            Tail.Next = node;
            node.Prev = Tail;
            Tail = node;
        }

        public T RemoveFirst()
        {
            if (isHeadNull)
                throw new Exception("The linked list is empty!");

            T item = default;

            if (Head.Equals(Tail))
            {
                item = Head.Value;
                Head = null;
                Tail = null;
                return item;
            }

            item = Head.Value;
            Head = Head.Next;
            Head.Prev = null;
            return item;
        }

        public T RemoveLast()
        {
            if (isHeadNull)
                throw new Exception("The linked list is empty!");

            if (Head.Equals(Tail))
            {
                T item2 = Head.Value;
                Head = null;
                Tail = null;
                return item2;
            }

            T item = Tail.Value;
            Tail = Tail.Prev;
            Tail.Next = null;
            return item;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new DoublyLinkedListEnumerator<T>(Head, Tail);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
