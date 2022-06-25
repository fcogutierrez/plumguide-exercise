using FluentAssertions;
using PlumGuide.Rover.Core.Enums;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.RoverTests
{
    public sealed class MoveForwardTests
    {
        [Theory]
        [InlineData(Facing.North, 5, 6)]
        [InlineData(Facing.South, 5, 4)]
        [InlineData(Facing.East, 6, 5)]
        [InlineData(Facing.West, 4, 5)]
        public void Given_PositionAndFacing_Should_MoveToANewPositionIfItIsValid(Facing facing, int expectedX, int expectedY)
        {
            var position = new Position(5, 5);
            var sut = new Rover(position, facing);

            sut.MoveForward();

            sut.Position.X.Should().Be(expectedX);
            sut.Position.Y.Should().Be(expectedY);
        }
    }
}
