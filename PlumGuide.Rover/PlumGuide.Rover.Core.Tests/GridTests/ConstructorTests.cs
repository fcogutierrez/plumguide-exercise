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
        public void Given_GridWithNonPositiveSizes_Should_ThrowAnArgumentOutOfRangeException(int width, int height)
        {
            var expectedException = Record.Exception(() => new Grid(width, height));

            expectedException.Should().BeAssignableTo<ArgumentOutOfRangeException>();
        }

        [Fact]
        public void Given_ValidSizes_Should_AssignValues()
        {
            var grid = new Grid(100, 50);

            grid.Width.Should().Be(100);
            grid.Height.Should().Be(50);
        }
    }
}
