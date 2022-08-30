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
        //[InlineData("1,\n", 0)]
        public void Add_PositiveIntegers(string value, int expected)
        {
            int result = StringCalculator.Add(value);
            Assert.Equal(expected, result);
        }
    }
}
