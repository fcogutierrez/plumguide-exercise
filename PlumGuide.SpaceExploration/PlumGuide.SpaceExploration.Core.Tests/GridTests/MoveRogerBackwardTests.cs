using FluentAssertions;
using PlumGuide.SpaceExploration.Core.Enums;
using PlumGuide.SpaceExploration.Core.Exceptions;
using Xunit;

namespace PlumGuide.SpaceExploration.Core.Tests.GridTests
{
    public sealed class MoveRogerBackwardTests
    {
        [Theory]
        [InlineData(Facing.North, 5, 0)]
        [InlineData(Facing.South, 5, 49)]
        [InlineData(Facing.East, 0, 5)]
        [InlineData(Facing.West, 49, 5)]
        public void Given_RoverInAValidPosition_Should_ThrowAMoveNotAllowedExceptionIfTheNewPositionIsNotAllowed(Facing facing, int currentX, int currentY)
        {
            var rover = new SpaceExploration.Core.Rover(new Position(currentX, currentY), facing);
            var sut = new Grid(50, 50, rover);

            var expectedException = Record.Exception(() => sut.MoveRoverBackward());

            expectedException.Should().BeAssignableTo<MoveNotAllowedException>();
        }

        [Fact]
        public void Given_RoverInAValidPosition_Should_ProcessTheMoveIfTheNewPositionIsAllowed()
        {
            var rover = new SpaceExploration.Core.Rover(new Position(25, 25), Facing.North);
            var sut = new Grid(50, 50, rover);

            sut.MoveRoverBackward();

            sut.Rover.Position.Should().NotBe(new Position(25, 25));
        }
    }
}