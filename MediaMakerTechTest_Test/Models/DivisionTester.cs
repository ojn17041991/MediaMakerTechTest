using MediaMakerTechTest.Models.Abstractions;
using MediaMakerTechTest.Models;
using Xunit;
using FluentAssertions;

namespace MediaMakerTechTest_Test.Models
{
    public class DivisionTester
    {
        [Theory]
        [InlineData(1, 1, 1)]
        [InlineData(10, 2, 5)]
        [InlineData(300, 200, 1.5)]
        public void AbleToDividePositiveNumbers(double input1, double input2, double expected)
        {
            BaseCalculation division = new Division()
            {
                Input1 = input1,
                Input2 = input2
            };

            division.Result.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, -5, -2)]
        [InlineData(-10, 1, -10)]
        [InlineData(-14, -7, 2)]
        public void AbleToDivideNegativeNumbers(double input1, double input2, double expected)
        {
            BaseCalculation division = new Division()
            {
                Input1 = input1,
                Input2 = input2
            };

            division.Result.Should().Be(expected);
        }

        [Theory]
        [InlineData(20, 0.5, 40)]
        [InlineData(12.25, 0.25, 49)]
        [InlineData(11, 1.1, 10)]
        public void AbleToDivideFloatingPointNumbers(double input1, double input2, double expected)
        {
            BaseCalculation division = new Division()
            {
                Input1 = input1,
                Input2 = input2
            };

            division.Result.Should().Be(expected);
        }
    }
}
