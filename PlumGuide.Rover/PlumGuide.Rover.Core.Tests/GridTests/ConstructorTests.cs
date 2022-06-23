using FluentAssertions;
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
        public void Given_GridWithNonPositiveWidthOrHeight_Should_ThrowAnArgumentOutOfRangeException(int width, int height)
        {
            var expectedException = Record.Exception(() => new Grid(width, height));

            expectedException.Should().BeAssignableTo<ArgumentOutOfRangeException>();
        }
    }
}
