using FluentAssertions;
using MediaMakerTechTest.Models;
using MediaMakerTechTest.Models.Abstractions;
using Xunit;

namespace MediaMakerTechTest_Test.Models
{
    public class AdditionTester
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(6, 9, 15)]
        [InlineData(300, 201, 501)]
        public void AbleToAddPositiveNumbers(double input1, double input2, double expected)
        {
            BaseCalculation addition = new Addition()
            {
                Input1 = input1,
                Input2 = input2
            };

            addition.Result.Should().Be(expected);
        }

        [Theory]
        [InlineData(10, -2, 8)]
        [InlineData(-70, 80, 10)]
        [InlineData(-2000, -3000, -5000)]
        public void AbleToAddNegativeNumbers(double input1, double input2, double expected)
        {
            BaseCalculation addition = new Addition()
            {
                Input1 = input1,
                Input2 = input2
            };

            addition.Result.Should().Be(expected);
        }

        [Theory]
        [InlineData(0.4, 0.6, 1)]
        [InlineData(12.25, 0.5, 12.75)]
        [InlineData(10.9, -0.9, 10)]
        public void AbleToAddFloatingPointNumbers(double input1, double input2, double expected)
        {
            BaseCalculation addition = new Addition()
            {
                Input1 = input1,
                Input2 = input2
            };

            addition.Result.Should().Be(expected);
        }
    }
}