using LinkedList.Doubly;
using LinkedList.Singly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public static class DoublyLinkedListSample
    {
        static void LinkedListTraverseSample()
        {
            var linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            var curr = linkedList.GetEnumerator();

            while (curr.MoveNext())
            {
                System.Console.WriteLine(curr.Current);
            }
        }

        static void DdNodeSample()
        {
            var samet = new DoublyLinkedListNode<string>("samet");
            var emircan = new DoublyLinkedListNode<string>("emircan");
            var bahar = new DoublyLinkedListNode<string>("bahar");
            var hafsa = new DoublyLinkedListNode<string>("hafsa");
            var zehra = new DoublyLinkedListNode<string>("zehra");
            var ismail = new DoublyLinkedListNode<string>("ismail");


            hafsa.Next = zehra;
            zehra.Next = samet;
            zehra.Prev = hafsa;
            samet.Next = ismail;
            samet.Prev = zehra;
            ismail.Next = new DoublyLinkedListNode<string>("muhammed");
            ismail.Prev = samet;
            ismail.Next.Next = emircan;
            ismail.Next.Prev = ismail;
            emircan.Next = bahar;
            emircan.Prev = ismail.Next;
            bahar.Prev = emircan;

            var head = hafsa;
            var tail = bahar;

            System.Console.WriteLine(head.Next == zehra); //hafsa,samet,true
            System.Console.WriteLine(head.Next.Next); //samet
            System.Console.WriteLine(head.Next.Next.Value); //samet
            System.Console.WriteLine(tail); //bahar
            System.Console.WriteLine(tail.Value); //bahar
            System.Console.WriteLine(tail.Prev.Prev.Prev); //emircan,ismail
        }

        static void NewMethod()
        {
            var linkedlist = new DoublyLinkedList<char>("Samsun".ToArray());
            foreach (var item in linkedlist)
            {
                System.Console.WriteLine(item);
            }

            System.Console.ReadKey();
        }

    }
}
