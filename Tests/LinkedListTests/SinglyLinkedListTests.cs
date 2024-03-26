using LinkedList.Singly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTests
{
    public class SinglyLinkedListTests
    {

        SinglyLinkedList<int> linkedList;

        public SinglyLinkedListTests()
        {
            this.linkedList = new SinglyLinkedList<int>(new int[] { 1, 2, 3 });
        }


        [Fact]
        public void NewLinkedListIsEmpty()
        {
            // Assert
            Assert.False(linkedList.IsEmpty);
        }

        [Fact]
        public void LinkedListWithCollectionIsPopulated()
        {
            //Act
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6 };

            //Arrange
            linkedList = new SinglyLinkedList<int>(arr);

            //Assert
            Assert.False(linkedList.IsEmpty);
            Assert.Equal(6, linkedList.Head.Value);
        }

        [Fact]
        public void AddFirstAddsElementToLinkedList()
        {
            linkedList.AddFirst(6);

            Assert.Equal(6, linkedList.Head.Value);
            Assert.Equal(3, linkedList.Head.Next.Value);
            Assert.Equal(4, linkedList.Count);
        }

        [Fact]
        public void AddLastAddsElementToEndOfLinkedList()
        {
            linkedList.AddLast(6);
            Assert.Equal(6, linkedList.Head.Next.Next.Next.Value);
            Assert.Equal(3, linkedList.Head.Value); 
            Assert.Equal(4, linkedList.Count);

        }

        [Fact]
        public void AddAfterAddsElementAfterGivenNode()
        {
            // Arrange
            var node = linkedList.Head; 

            // Act
            linkedList.AddAfter(node, 8); 

            // Assert
            Assert.Equal(3, node.Value); 
            Assert.Equal(8, node.Next.Value); 
            Assert.Equal(2, node.Next.Next.Value); 
            Assert.Equal(1, node.Next.Next.Next.Value); 

        }

        [Fact]
        public void AddAfterThrowsExceptionIfNodeNotFound()
        {
            Assert.Throws<Exception>(() => linkedList.AddAfter(new SinglyLinkedListNode<int>(5), 1));
        }

        [Fact]
        public void AddBeforeAddsElementBeforeGivenNode()
        {
            // Arrange
            var node = linkedList.Head.Next; 

            // Act
            linkedList.AddBefore(node, 8); 

            // Assert
            Assert.Equal(3, linkedList.Head.Value); 
            Assert.Equal(8, linkedList.Head.Next.Value); 
            Assert.Equal(2, linkedList.Head.Next.Next.Value); 
            Assert.Equal(1, linkedList.Head.Next.Next.Next.Value); 
        }

        [Fact]
        public void AddBeforeThrowsExceptionIfNodeNotFound()
        {
            Assert.Throws<Exception>(() => linkedList.AddBefore(new SinglyLinkedListNode<int>(5), 1));
        }

        [Fact]
        public void RemoveFirstRemovesFirstElement()
        {
            // Act
            var item = linkedList.RemoveFirst();

            // Assert
            Assert.Equal(3, item);
        }

        [Fact]
        public void RemoveFirstThrowsExceptionIfListIsEmpty()
        {
            linkedList = new SinglyLinkedList<int>();
            Assert.Throws<Exception>(() => linkedList.RemoveLast());
        }

        [Fact]
        public void RemoveLastRemovesLastElement()
        {
            // Act
            var item = linkedList.RemoveLast();

            // Assert
            Assert.Equal(1, item);
        }

        [Fact]
        public void RemoveLastThrowsExceptionIfListIsEmpty()
        {
            linkedList = new SinglyLinkedList<int>();
            Assert.Throws<Exception>(() => linkedList.RemoveLast());
        }

        [Fact]
        public void RemoveRemovesGivenNode()
        {
            // Act
            var item = linkedList.Remove(new SinglyLinkedListNode<int>(2));

            // Assert
            Assert.Equal(2, item);
        }

        [Fact]
        public void RemoveThrowsExceptionIfNodeNotFound()
        {
            Assert.Throws<Exception>(() => linkedList.Remove(new SinglyLinkedListNode<int>(4)));
        }
    }
}
