using LinkedList.Doubly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Contracts
{
    public interface IDoublyLinkedList<T> : IEnumerable<T>
    {
        DoublyLinkedListNode<T>? Head { get; }
        DoublyLinkedListNode<T>? Tail { get; }

        void AddFirst(T item);
        void AddLast(T item);
        T RemoveFirst();
        T RemoveLast();
    }
}
