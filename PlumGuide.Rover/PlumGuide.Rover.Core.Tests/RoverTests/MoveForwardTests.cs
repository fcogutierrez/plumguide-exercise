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
        public void Given_PositionAndFacing_Should_ChangeToExpectedPositionAndDoNotChangeFacing(Facing facing, int expectedX, int expectedY)
        {
            var initialPosition = new Position(5, 5);
            var expectedPosition = new Position(expectedX, expectedY);
            var sut = new Rover(initialPosition, facing);

            sut.MoveForward();

            sut.Position.Should().Be(expectedPosition);
            sut.Facing.Should().Be(facing);
        }
    }
}
