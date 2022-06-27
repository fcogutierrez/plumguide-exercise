using FluentAssertions;
using PlumGuide.Rover.Core.Enums;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.GridTests
{
    public sealed class TurnRoverLeftTests
    {
        [Fact]
        public void Given_RoverInAValidPosition_Should_ChangeTheFacing()
        {
            var rover = new Rover(new Position(25, 25), Facing.North);
            var grid = new Grid(50, 50, rover);

            grid.TurnRoverRight();

            grid.Rover.Facing.Should().NotBe(Facing.North);
        }
    }
}
