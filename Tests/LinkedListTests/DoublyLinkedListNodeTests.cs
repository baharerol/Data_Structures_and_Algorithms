using LinkedList.Doubly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListTests
{
    public class DoublyLinkedListNodeTests
    {
        [Fact]
        public void Constructor_WithValue_SetsValue()
        {
            var node = new DoublyLinkedListNode<int>(5);

            Assert.True(node.Value.Equals(5));
        }

        [Fact]
        public void Constructor_WithoutValue_ValueIsNull()
        {
            var node = new DoublyLinkedListNode<int>();
            node.Value = 5;

            Assert.True(node.Value.Equals(5));

        }

        [Fact]
        public void NextProperty_CanBeSetAndGet()
        {
            var node = new DoublyLinkedListNode<int>(5);
            var new_node = new DoublyLinkedListNode<int>(10);

            node.Next = new_node;

            Assert.Equal(10, node.Next.Value); // new_node.Value
        }

        [Fact]
        public void PrevProperty_CanBeSetAndGet()
        {
            var node = new DoublyLinkedListNode<int>(5);
            var new_node = new DoublyLinkedListNode<int>(10);

            node.Prev = new_node;

            Assert.Equal(new_node, node.Prev); 
            Assert.Null(node.Prev.Next);
        }

        [Fact]
        public void ToString_ReturnsValueAsString()
        {
            var node = new DoublyLinkedListNode<int>(10);

            Assert.Equal("10", node.ToString()); // new_node.Value
        }
    }
}
