using FluentAssertions;
using PlumGuide.Rover.Core.Enums;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.GridTests
{
    public sealed class ConstructorTests
    {
        [Theory]
        [InlineData(5, 0)]
        [InlineData(5, -5)]
        [InlineData(0, 10)]
        [InlineData(-10, 10)]
        [InlineData(-10, -5)]
        public void Given_GridWithNonPositiveSizes_Should_ThrowAnArgumentOutOfRangeException(int width, int height)
        {
            var rover = new Rover(new Position(0, 0), Facing.North);
            var expectedException = Record.Exception(() => new Grid(width, height, rover));

            expectedException.Should().BeAssignableTo<ArgumentOutOfRangeException>();
        }

        [Theory]
        [InlineData(-1, 5)]
        [InlineData(50, 5)]
        [InlineData(5, -1)]
        [InlineData(5, 101)]
        public void Given_GridWithRoverInInvalidPosition_Should_ThrowAnArgumentException(int roverPositionX, int roverPositionY)
        {
            var rover = new Rover(new Position(roverPositionX, roverPositionY), Facing.North);
            var expectedException = Record.Exception(() => new Grid(50, 100, rover));

            expectedException.Should().BeAssignableTo<ArgumentException>();
        }

        [Fact]
        public void Given_ValidParameters_Should_AssignValues()
        {
            var rover = new Rover(new Position(10, 10), Facing.North);
            var grid = new Grid(100, 100, rover);

            grid.Width.Should().Be(100);
            grid.Height.Should().Be(100);

            grid.Rover.Position.Should().Be(new Position(10, 10));
            grid.Rover.Facing.Should().Be(Facing.North);
        }
    }
}