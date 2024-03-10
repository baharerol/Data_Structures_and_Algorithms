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
        public void Check_Multiply()
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
            var result = number.Value;

            // Assert 
            Assert.True(true);
            Assert.False(false);
            Assert.Equal(5, 10);
        }

        [Fact]
        public void Check_Multiply_With_NoParameter()
        {
            throw new NotImplementedException();
        }


        [Fact]
        public void Check_Number_MinValue()
        {
            throw new NotImplementedException();
        }


        [Fact]
        public void Check_Number_MaxValue()
        {
            throw new NotImplementedException();
        }


        [Fact]
        public void Check_ToString()
        {
            throw new NotImplementedException();
        }
    }
}
