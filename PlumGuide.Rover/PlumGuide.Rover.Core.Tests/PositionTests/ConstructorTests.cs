using FluentAssertions;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.PositionTests
{
    public sealed class ConstructorTests
    {
        [Theory]
        [InlineData(5, -5)]        
        [InlineData(-10, 10)]
        [InlineData(-10, -5)]

        public void Given_AnyNegativeCoordinate_Should_ThrowAnArgumentOutOfRangeException(int x, int y)
        {
            var expectedException = Record.Exception (() => new Position(x, y));

            expectedException.Should().BeAssignableTo<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Given_ValidCoordinates_Should_AssignValues()
        {
            var position = new Position(10, 5);

            position.X.Should().Be(10);
            position.Y.Should().Be(5);
        }
    }
}