using System;
using Xunit;
using PriceCalculator2Kata;

namespace PriceCalculatorTests
{
    public class StringCalculatorTest
    {
        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("", 0)]
        [InlineData("1,2\n10", 13)]
        public void Add_PositiveNumbers_ReturnInt(string value, int expected)
        {
            int result = StringCalculator.Add(value);
            Assert.Equal(expected, result);
        }

      
        [Theory]
       // [InlineData("1,2,3")]
        [InlineData("1,-2,3")]
        public void Add_Negatives_ThrowException(string value)
        {
            Assert.Throws<ArgumentException>(() => StringCalculator.Add(value));
        }
    }
}
