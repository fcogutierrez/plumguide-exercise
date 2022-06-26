using FluentAssertions;
using PlumGuide.Rover.Core.Enums;
using PlumGuide.Rover.Core.Exceptions;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.GridTests
{
    public sealed class MoveRoverForwardTests
    {
        [Theory]
        [InlineData(Facing.North, 5, 49)]
        [InlineData(Facing.South, 5, 0)]
        [InlineData(Facing.East, 49, 5)]
        [InlineData(Facing.West, 0, 5)]
        public void Given_RoverInAValidPosition_Should_ThrowAMoveNotAllowedExceptionIfTheNewPositionIsNotAllowed(Facing facing, int currentX, int currentY)
        {
            var rover = new Rover(new Position(currentX, currentY), facing);
            var grid = new Grid(50, 50, rover);

            var expectedException = Record.Exception(() => grid.MoveRoverForward());

            expectedException.Should().BeAssignableTo<MoveNotAllowedException>();
        }

        [Fact]
        public void Given_RoverInAValidPosition_Should_ProcessTheMoveIfTheNewPositionIsAllowed()
        {
            var rover = new Rover(new Position(25, 25), Facing.North);
            var grid = new Grid(50, 50, rover);

            grid.MoveRoverForward();

            grid.Rover.Position.Should().NotBe(new Position(25, 25));
        }
    }
}