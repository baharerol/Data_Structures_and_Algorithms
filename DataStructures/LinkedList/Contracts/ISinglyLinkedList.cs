using LinkedList.Singly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Contracts
{
    public interface ISinglyLinkedList<T>
    {
        SinglyLinkedListNode<T>? Head { get; }
        int Count { get; }
        void AddFirst(T item);
        void AddLast(T item);
        void AddBefore(SinglyLinkedListNode<T> node, T item);
        void AddAfter(SinglyLinkedListNode<T> node, T item);
        T RemoveFirst();
        public T RemoveLast();
        T Remove(SinglyLinkedListNode<T> node);

    }
}
