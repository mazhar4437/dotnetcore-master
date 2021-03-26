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

            var result = calc.Add("323a,1");

            result.Should().Be(324);
        }

       
    }
}
