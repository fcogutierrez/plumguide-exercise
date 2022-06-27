using FluentAssertions;
using PlumGuide.SpaceExploration.Core.Enums;
using Xunit;

namespace PlumGuide.SpaceExploration.Core.Tests.GridTests
{
    public sealed class TurnRoverRightTests
    {
        [Fact]
        public void Given_RoverInAValidPosition_Should_ChangeTheFacing()
        {
            var rover = new Rover(new Position(25, 25), Facing.North);
            var sut = new Grid(50, 50, rover);

            sut.TurnRoverRight();

            sut.Rover.Facing.Should().NotBe(Facing.North);
        }
    }
}
