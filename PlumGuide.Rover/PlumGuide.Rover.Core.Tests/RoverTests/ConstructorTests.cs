using FluentAssertions;
using PlumGuide.Rover.Core.Enums;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.RoverTests
{
    public sealed class ConstructorTests
    {
        [Fact]
        public void Given_MissingPosition_Should_ThrowAnArgumentNullException()
        {
            var expectedException = Record.Exception(() => new Rover(default!, Facing.North));

            expectedException.Should().BeAssignableTo<ArgumentNullException>();
        }

        [Fact]
        public void Given_PositionAndFacing_Should_AssignValues()
        {
            var position = new Position(20, 1);
            var rover = new Rover(position, Facing.North);

            rover.Facing.Should().Be(Facing.North);
            rover.Position.Should().Be(new Position(20, 1));
        }
    }
}