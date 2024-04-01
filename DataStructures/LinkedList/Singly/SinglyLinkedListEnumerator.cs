using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Singly
{
    public class SinglyLinkedListEnumerator<T>:IEnumerator<T>
    {
        public SinglyLinkedListNode<T>? Head { get; set; }
        public SinglyLinkedListNode<T>? Curr { get; set; }

        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            Head = head;
            Curr = null;
        }
        public T Current => Curr.Value ?? default;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
            Head = null;
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
            Curr = null;
            Head = null;
        }
    }
}
