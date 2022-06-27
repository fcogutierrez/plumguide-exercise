using FluentAssertions;
using PlumGuide.SpaceExploration.Application.Commands;
using PlumGuide.SpaceExploration.Core;
using PlumGuide.SpaceExploration.Core.Enums;
using Xunit;

namespace PlumGuide.SpaceExploration.Application.Tests.MoveRoverCommandHandlerTests
{
    public sealed class HandleTests
    {
        [Fact]
        public void Given_MissingCommand_Should_ThrowAnArgumentNullException()
        {
            var rover = new Rover(new Position(0,0), Facing.North);
            var grid = new Grid(50, 50, rover);

            var sut = new MoveRoverCommandHandler(grid);

            var expectedException = Record.Exception(() => sut.Handle(default));

            expectedException.Should().BeAssignableTo<ArgumentNullException>();
        }

        [Theory]
        [InlineData(0, 0, Facing.North, "FFRFF", 2, 2, Facing.East)]
        [InlineData(0, 0, Facing.North, "FRFLFF", 1, 3, Facing.North)]
        [InlineData(0, 0, Facing.North, "RRR", 0, 0, Facing.West)]
        public void Given_CommandWithValidRoadMapInstructions_Should_MoveRoverToTheExpectedPositionAndFacing(int initialX, int initialY, Facing initialFacing, string roadMap, int expectedX, int expectedY, Facing expectedFacing)
        {
            var initialPosition = new Position(initialX, initialY);
            var rover = new Rover(initialPosition, initialFacing);
            var grid = new Grid(50, 50, rover);

            var sut = new MoveRoverCommandHandler(grid);
            var command = new MoveRoverCommand(roadMap);

            sut.Handle(command);

            var expectedPosition = new Position(expectedX, expectedY);

            sut.Grid.Rover.Position.Should().Be(expectedPosition);
            sut.Grid.Rover.Facing.Should().Be(expectedFacing);
        }

        [Fact]
        public void Given_CommandWithInvalidRoadMapInstructions_Should_ThrowANotSupportedException()
        {
            var initialPosition = new Position(0, 0);
            var rover = new Rover(initialPosition, Facing.North);
            var grid = new Grid(50, 50, rover);

            var sut = new MoveRoverCommandHandler(grid);

            const string invalidRoadMap = "INVALID";
            var command = new MoveRoverCommand(invalidRoadMap);

            var expectedException = Record.Exception(() => sut.Handle(command));

            expectedException.Should().BeAssignableTo<NotSupportedException>();
        }
    }
}