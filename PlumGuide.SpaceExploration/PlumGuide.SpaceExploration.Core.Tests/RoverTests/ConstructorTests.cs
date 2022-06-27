using FluentAssertions;
using PlumGuide.SpaceExploration.Core.Enums;
using Xunit;

namespace PlumGuide.SpaceExploration.Core.Tests.RoverTests
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
            var sut = new Rover(position, Facing.North);

            sut.Facing.Should().Be(Facing.North);
            sut.Position.Should().Be(new Position(20, 1));
        }
    }
}