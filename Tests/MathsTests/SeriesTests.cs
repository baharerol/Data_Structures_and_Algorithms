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
        }

        [Fact]
        public void Check_First_Item_In_Series()
        {
            //Arrange
            int[] testData = { 1, 2, 3, 4, 5 };
            Series<int> series = new Series<int>(testData);

            //Act
            int firstItem = series.FirstItem;

            //Assert
            Assert.Equal(1, firstItem);

        }

        [Fact]
        public void Check_Last_Item_In_Series()
        {
            //Arrange
            int[] testData = { 1, 2, 3, 4, 5 };
            Series<int> series = new Series<int>(testData);

            //Act
            int lastItem = series.LastItem;

            //Assert
            Assert.Equal(5, lastItem);
        }

        [Fact]
        public void Check_Count()
        {
            //Arrange
            int[] testData = { 1, 2, 3, 4, 5 };
            Series<int> series = new Series<int>(testData);

            //Act
            int count = series.Count;

            //Assert
            Assert.Equal(5, count);
        }

        [Fact]
        public void Check_ToString()
        {
            //Arrange
            int[] testData = { 1, 2, 3, 4, 5 };
            Series<int> series = new Series<int>(testData);

            //Act
            var result = series.ToString();

            //Assert
            Assert.Equal("12345", result);
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
