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

        public void Given_PositionWithAnyNegativeCoordinate_Should_ThrowAnArgumentOutOfRangeException(int x, int y)
        {
            var expectedException = Record.Exception (() => new Position(x, y));

            expectedException.Should().BeAssignableTo<ArgumentOutOfRangeException>();
        }
    }
}
