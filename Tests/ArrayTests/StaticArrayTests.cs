using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTests
{
    public class StaticArrayTests
    {
        private StaticArray<char> _array;
        public StaticArrayTests()
        {
            // Arrange
            _array = new StaticArray<char>();
            _array.SetItem(0, 'a');
            _array.SetItem(1, 'b');
            _array.SetItem(2, 'c');
            _array.SetItem(3, 'd');
        }

        [Fact]
        public void DefaultConstructor_InitializesArrayWithCorrectLength()
        {
            // Act
            var length = _array.Length;

            // Assert
            Assert.Equal(4, length);
        }

        [Fact]
        public void Get_Item_Test()
        {
            // Act
            var item = _array.GetItem(2);

            // Assert
            Assert.Equal('c', item);
        }

        [Fact]
        public void SetItem_ChangesValue()
        {
            // Act
            _array.SetItem(3, 'e');
            var item = _array.GetItem(3);

            // Assert
            Assert.Equal('e', item);
        }

        [Fact]
        public void SetItem_ThrowsIndexOutOfRangeException_ForInvalidIndex()
        {
            Assert.Throws<IndexOutOfRangeException>(() => _array.SetItem(-1, 'f'));
            Assert.Throws<IndexOutOfRangeException>(() => _array.SetItem(5, 'g'));

        }

        [Fact]
        public void GetItem_ThrowsIndexOutOfRangeException_ForInvalidIndex()
        {
            Assert.Throws<IndexOutOfRangeException>(() => _array.GetItem(-1));  
            Assert.Throws<IndexOutOfRangeException>(() => _array.GetItem(5));  

            
        }

        [Fact]
        public void Length_Test()
        {
            //Act
            var result = _array.Length;

            //Assert
            Assert.Equal(4, result);
           
        }

        [Fact]
        public void Constructor_with_IEnumerable_Parameter_Test()
        {
            // Arrange
            var collection = new List<int> { 1, 2, 3, 4 };

            // Act
            var staticArray = new StaticArray<int>(collection);

            // Assert
            Assert.Equal(collection.Count, staticArray.Length); 

            for (int i = 0; i < collection.Count; i++)
            {
                Assert.Equal(collection[i], staticArray.GetItem(i)); 
            }
        }
    

        [Fact]
        public void GetEnumerator_ReturnsAllItemsInArray()
        {
            // Arrange
            var enumerator = _array.GetEnumerator();
            var items = new char[_array.Length];
            int i = 0;

            //Act
            while (enumerator.MoveNext())
            {
                items[i] = (char)enumerator.Current;
                i++;
            }

            // Assert
            Assert.Collection(items,
            item => Assert.Equal('a', item),
            item => Assert.Equal('b', item),
            item => Assert.Equal('c', item),
            item => Assert.Equal('d', item)
            );
        }
    }
}
