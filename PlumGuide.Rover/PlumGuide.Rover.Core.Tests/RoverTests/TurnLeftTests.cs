using FluentAssertions;
using PlumGuide.Rover.Core.Enums;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.RoverTests
{
    public sealed class TurnLeftTests
    {
        [Theory]
        [InlineData(Facing.North, Facing.West)]
        [InlineData(Facing.West, Facing.South)]
        [InlineData(Facing.South, Facing.East)]
        [InlineData(Facing.East, Facing.North)]
        public void Given_PositionAndFacing_Should_ChangeToTheCorrectFacingAndDoNotChangeThePosition(Facing initialFacing, Facing expectedFacing)
        {
            var initialPosition = new Position(5, 5);
            var sut = new Rover(initialPosition, initialFacing);

            sut.TurnLeft();

            sut.Position.Should().Be(initialPosition);
            sut.Facing.Should().Be(expectedFacing);
        }
    }
}
