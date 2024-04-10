using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Doubly
{
    public class DoublyLinkedListEnumerator<T>:IEnumerator<T>
    {
        private DoublyLinkedListNode<T> Head { get; set; }
        private DoublyLinkedListNode<T> Tail { get; set; }
        public DoublyLinkedListNode<T> Curr { get; set; }

        public DoublyLinkedListEnumerator()
        {

        }

        public DoublyLinkedListEnumerator(DoublyLinkedListNode<T> head, DoublyLinkedListNode<T> tail)
        {
            this.Head = head;
            this.Tail = tail;
            Curr = null;
        }

        public T Current => Curr.Value ?? default(T);

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
            Tail = null;
        }

        public bool MoveNext()
        {
            if (Head is null)
                return false;

            if (Curr is null)
            {
                Curr = Head;
                return true;
            }

            if (Curr.Next is not null)
            {
                Curr = Curr.Next;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Head = null;
            Tail = null;
            Curr = null;
        }
    }
}
}
