using FluentAssertions;
using Xunit;

namespace PlumGuide.SpaceExploration.Core.Tests.PositionTests
{
    public sealed class ConstructorTests
    {
        [Fact]
        public void Given_Coordinates_Should_AssignValues()
        {
            var sut = new Position(10, 5);

            sut.X.Should().Be(10);
            sut.Y.Should().Be(5);
        }
    }
}