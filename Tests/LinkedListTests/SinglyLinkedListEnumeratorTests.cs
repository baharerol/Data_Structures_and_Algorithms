using LinkedList.Singly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTests
{
    public class SinglyLinkedListEnumeratorTests
    {

        [Fact]
        public void Enumerator_MoveNext_ShouldReturnTrueWhenListIsNotEmpty()
        {
            var list = new SinglyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);

            var enumerator = new SinglyLinkedListEnumerator<int>(list.Head);

            Assert.True(enumerator.MoveNext());
            Assert.Equal(1, enumerator.Current);

        }

        [Fact]
        public void Enumerator_MoveNext_ShouldReturnFalseWhenListIsEmpty()
        {

            var list = new SinglyLinkedList<int>();
            
            var enumerator = new SinglyLinkedListEnumerator<int>(list.Head);

            Assert.False(enumerator.MoveNext());
            
        }

        [Fact]
        public void Enumerator_Reset_ShouldResetCurrentToNull()
        {
            var list = new SinglyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);

            var enumerator = new SinglyLinkedListEnumerator<int>(list.Head);

            enumerator.MoveNext();
            var item = enumerator.Current;
            enumerator.Reset();
            Assert.Throws<NullReferenceException>(() => enumerator.Current);

            Assert.Equal(1, item);
            Assert.Equal(null, enumerator.Curr);

        }

        [Fact]
        public void Enumerator_Dispose_ShouldSetHeadToNull()
        {
            var list = new SinglyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);

            var enumerator = new SinglyLinkedListEnumerator<int>(list.Head);

            enumerator.Dispose();

            Assert.Null(enumerator.Head);

        }

        [Fact]
        public void Enumerator_Current_ShouldReturnCurrentValue()
        {
            var list = new SinglyLinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);

            var enumerator = new SinglyLinkedListEnumerator<int>(list.Head);

            enumerator.MoveNext();
            var item = enumerator.Current;
            enumerator.MoveNext();
            var item2 = enumerator.Current;

            Assert.Equal(1, item);
            Assert.Equal(2, item2);
            Assert.Equal(item2, enumerator.Curr.Value);
        }
    }
}

