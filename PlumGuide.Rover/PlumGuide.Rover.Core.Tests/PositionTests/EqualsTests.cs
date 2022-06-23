using FluentAssertions;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.PositionTests
{
    public sealed class EqualsTests
    {
        [Fact]
        public void Given_SamePositions_Should_ReturnTrue()
        {
            var positionOne = new Position(10, 10);
            var positionTwo = new Position(10, 10);

            var result = positionOne.Equals(positionTwo);

            result.Should().BeTrue();
        }

        [Fact]
        public void Given_DifferentPositions_Should_ReturnFalse()
        {
            var positionOne = new Position(10, 5);
            var positionTwo = new Position(5, 10);

            var result = positionOne.Equals(positionTwo);

            result.Should().BeFalse();
        }
    }
}