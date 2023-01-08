using MediaMakerTechTest.Models.Abstractions;
using MediaMakerTechTest.Models;
using Xunit;
using FluentAssertions;

namespace MediaMakerTechTest_Test.Models
{
    public class SubtractionTester
    {
        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(9, 6, 3)]
        [InlineData(250, 200, 50)]
        public void AbleToSubtractPositiveNumbers(double input1, double input2, double expected)
        {
            BaseCalculation subtraction = new Subtraction()
            {
                Input1 = input1,
                Input2 = input2
            };

            subtraction.Result.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, -2, 12)]
        [InlineData(-70, 80, -150)]
        [InlineData(-2000, -4000, 2000)]
        public void AbleToSubtractNegativeNumbers(double input1, double input2, double expected)
        {
            BaseCalculation subtraction = new Subtraction()
            {
                Input1 = input1,
                Input2 = input2
            };

            subtraction.Result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.4, 0.4, 0)]
        [InlineData(1.6, 0.6, 1)]
        [InlineData(11.11, -2.89, 14)]
        public void AbleToSubtractFloatingPointNumbers(double input1, double input2, double expected)
        {
            BaseCalculation subtraction = new Subtraction()
            {
                Input1 = input1,
                Input2 = input2
            };

            subtraction.Result.Should().Be(expected);
        }
    }
}
