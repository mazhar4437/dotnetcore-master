using FluentAssertions;
using System;
using Xunit;

namespace dotnetcore
{
    public class StringCalculatorTest
    {

        [Fact]
        public void Add_WhenCalledWithEmptyString_ReturnZero()
        {
            var calc = new StringCalculator();

            var result = calc.Add(string.Empty);

            result.Should().Be(0);
        }

        [Fact]
        public void Add_WhenCalledWithoutCommaSeperatedValues_ReturnsthatNumber()
        {
            var calc = new StringCalculator();

            var result = calc.Add("323a");

            result.Should().Be(323);
        }

        // [Theory]
        // [InlineData("323232,432432", 755664)]
        // [InlineData("323232,432432,3423423", 4179087)]
        // public void Add_WhenCalledWithArbitaryCommaSeperatedStringValues_ReturnsSumofNumbers(string numbers,int expectedResult)
        // {
        //     var calc = new StringCalculator();

        //     var result = calc.Add(numbers);

        //     result.Should().Equals(expectedResult);
        // }

        // [Fact]
        // public void Add_WhenCalledContainsNewlinebetweenNumbers_ReturnsSumofNumbers()
        // {
        //     var calc = new StringCalculator();

        //     var result = calc.Add("323232\n432432,3423423");

        //     result.Should().Equals(4179087);
        // }


    }
}
