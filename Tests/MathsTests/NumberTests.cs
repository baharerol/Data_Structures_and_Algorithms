using Maths;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MathsTests
{
    public class NumberTests
    {
        [Fact]
        public void Check_Multiply_With_NoParameter()
        {
            // Arrange
            var number = new Number(5);

            // Act
            var result = number.Multiply();

            // Assert
            Assert.Equal(10, result);
        }


        [Fact]
        public void Check_Multiply_With_Parameter()
        {
            // Arrange
            var number = new Number(10);

            // Act
            var result = number.Multiply(2);

            // Assert 
            Assert.Equal(20, result);
        }


        [Fact]
        public void Check_Number_MinValue()
        {
            //Arrange
            var number = new Number();

            //Assert
            Assert.Equal(int.MinValue, number.MinValue);

        }


        [Fact]
        public void Check_Number_MaxValue()
        {
            //Arrange
            var number = new Number();

            //Assert
            Assert.Equal(int.MaxValue, number.MaxValue);
        }


        [Fact]
        public void Check_ToString()
        {
            // Arrange
            var number = new Number(5);

            // Act
            var result = number.ToString();

            // Assert
            Assert.Equal("5", result);
        }
    }
}
