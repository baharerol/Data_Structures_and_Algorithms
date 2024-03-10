using Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsTests
{
    public class SeriesTests
    {
        private Series<char> _series { get; set; }

        public SeriesTests()
        {
            // Arrange
            _series = new Series<char>("hello".ToCharArray());
        }

        [Fact]
        public void Check_First_Item_In_Series()
        {
            // Act
            if (_series.Count == 0)
                Assert.Throws<InvalidOperationException>(() => _series.FirstItem);

            var result = _series.FirstItem;

            // Asserts
            Assert.Equal('h', result);

        }

        [Fact]
        public void Check_Last_Item_In_Series()
        {
            // Act
            if (_series.Count == 0)
                Assert.Throws<InvalidOperationException>(() => _series.LastItem);

            var result = _series.LastItem;

            // Asserts
            Assert.Equal('o', result);
        }

        [Fact]
        public void Check_Count()
        {
            //Act
            int count = _series.Count;

            //Assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void Check_ToString()
        {
            //Act
            var result = _series.ToString();

            //Assert
            Assert.Equal("hello", result);
        }

        [Fact]
        public void Chekc_Equals()
        {
            // Arrange 
            var seriesA = new Series<int>(new int[] { 1, 2, 3 });
            var seriesB = new Series<int>(new int[] { 1, 2, 3 });

            // Act
            var result = seriesA.MyEquals(seriesB);

            // Assert
            Assert.True(result);
        }
    }
}
