using FluentAssertions;
using PlumGuide.SpaceExploration.Core.Enums;
using Xunit;

namespace PlumGuide.SpaceExploration.Core.Tests.RoverTests
{
    public sealed class GetPositionAfterMovingBackwardTests
    {
        [Theory]
        [InlineData(Facing.North, 5, 4)]
        [InlineData(Facing.South, 5, 6)]
        [InlineData(Facing.East, 4, 5)]
        [InlineData(Facing.West, 6, 5)]
        public void Given_PositionAndFacing_Should_ReturnTheExpectedPosition(Facing facing, int expectedX, int expectedY)
        {
            var initialPosition = new Position(5, 5);
            var expectedPosition = new Position(expectedX, expectedY);
            var sut = new Rover(initialPosition, facing);

            var result = sut.GetPositionAfterMovingBackward();

            result.Should().Be(expectedPosition);
        }
    }
}