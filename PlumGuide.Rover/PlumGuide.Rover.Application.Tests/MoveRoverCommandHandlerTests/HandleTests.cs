using FluentAssertions;
using PlumGuide.Rover.Application.Commands;
using PlumGuide.Rover.Core;
using PlumGuide.Rover.Core.Enums;
using Xunit;

namespace PlumGuide.Rover.Application.Tests.MoveRoverCommandHandlerTests
{
    public sealed class HandleTests
    {
        [Theory]
        [InlineData(0, 0, Facing.North, "FFRFF", 2, 2, Facing.East)]
        [InlineData(0, 0, Facing.North, "FRFLFF", 1, 3, Facing.North)]
        public void Given_RoverWithinAGrid_Should_BeMovedToTheExpectedPosition(int initialX, int initialY, Facing initialFacing, string roadMap, int expectedX, int expectedY, Facing expectedFacing)
        {
            var initialPosition = new Position(initialX, initialY);
            var rover = new Core.Rover(initialPosition, initialFacing);
            var grid = new Grid(50, 50, rover);

            var sut = new MoveRoverCommandHandler(grid);
            var command = new MoveRoverCommand(roadMap);

            sut.Handle(command);

            var expectedPosition = new Position(expectedX, expectedY);

            sut.Grid.Rover.Position.Should().Be(expectedPosition);
            sut.Grid.Rover.Facing.Should().Be(expectedFacing);
        }
    }
}