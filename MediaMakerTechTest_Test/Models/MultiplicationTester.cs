using MediaMakerTechTest.Models.Abstractions;
using MediaMakerTechTest.Models;
using Xunit;
using FluentAssertions;

namespace MediaMakerTechTest_Test.Models
{
    public class MultiplicationTester
    {
        [Theory]
        [InlineData(40, 50, 2000)]
        [InlineData(1, 999999999, 999999999)]
        [InlineData(7, 8, 56)]
        public void AbleToMultiplyPositiveNumbers(double input1, double input2, double expected)
        {
            BaseCalculation multiplication = new Multiplication()
            {
                Input1 = input1,
                Input2 = input2
            };

            multiplication.Result.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, -2, -20)]
        [InlineData(-15, 8, -120)]
        [InlineData(-1000000, -95, 95000000)]
        public void AbleToMultiplyNegativeNumbers(double input1, double input2, double expected)
        {
            BaseCalculation multiplication = new Multiplication()
            {
                Input1 = input1,
                Input2 = input2
            };

            multiplication.Result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.5, 0.5, 0.25)]
        [InlineData(100, 1.5, 150)]
        [InlineData(0.1, -1, -0.1)]
        public void AbleToMultiplyFloatingPointNumbers(double input1, double input2, double expected)
        {
            BaseCalculation multiplication = new Multiplication()
            {
                Input1 = input1,
                Input2 = input2
            };

            multiplication.Result.Should().Be(expected);
        }
    }
}
