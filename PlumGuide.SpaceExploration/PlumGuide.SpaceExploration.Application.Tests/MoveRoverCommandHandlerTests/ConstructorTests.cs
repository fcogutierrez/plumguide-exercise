using FluentAssertions;
using PlumGuide.SpaceExploration.Core;
using PlumGuide.SpaceExploration.Core.Enums;
using Xunit;

namespace PlumGuide.SpaceExploration.Application.Tests.MoveRoverCommandHandlerTests
{
    public sealed class ConstructorTests
    {
        [Fact]
        public void Given_MissingGrid_Should_ThrowAnArgumentNullException()
        {
            var expectedException = Record.Exception(() => new MoveRoverCommandHandler(default));

            expectedException.Should().BeAssignableTo<ArgumentNullException>();
        }

        [Fact]
        public void Given_Grid_Should_AssignIt()
        {
            var rover = new Rover(new Position(0, 5), Facing.North);
            var grid = new Grid(50, 100, rover);

            var sut = new MoveRoverCommandHandler(grid);

            sut.Grid.Width.Should().Be(50);
            sut.Grid.Height.Should().Be(100);
            sut.Grid.Rover.Facing.Should().Be(Facing.North);
            sut.Grid.Rover.Position.Should().Be(new Position(0, 5));
        }
    }
}
