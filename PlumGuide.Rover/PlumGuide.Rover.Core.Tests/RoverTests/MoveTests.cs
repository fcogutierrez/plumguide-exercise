using FluentAssertions;
using PlumGuide.Rover.Core.Enums;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.RoverTests
{
    public sealed class MoveTests
    {
        [Theory]
        [InlineData(Facing.North, Direction.Forward, 5, 6)]
        [InlineData(Facing.South, Direction.Forward, 5, 4)]
        [InlineData(Facing.East, Direction.Forward, 6, 5)]
        [InlineData(Facing.West, Direction.Forward, 4, 5)]
        [InlineData(Facing.North, Direction.Backward, 5, 4)]
        [InlineData(Facing.South, Direction.Backward, 5, 6)]
        [InlineData(Facing.East, Direction.Backward, 4, 5)]
        [InlineData(Facing.West, Direction.Backward, 6, 5)]
        public void Given_PositionAndFacing_Should_MoveToANewPositionIfItIsValid(Facing facing, Direction directionToMove, int expectedX, int expectedY)
        {
            var position = new Position(5, 5);
            var sut = new Rover(position, facing);

            sut.Move(directionToMove);

            sut.Position.X.Should().Be(expectedX);
            sut.Position.Y.Should().Be(expectedY);
        }
    }
}