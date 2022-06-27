using FluentAssertions;
using Xunit;

namespace PlumGuide.SpaceExploration.Core.Tests.PositionTests
{
    public sealed class EqualsTests
    {
        [Fact]
        public void Given_SamePositions_Should_ReturnTrue()
        {
            var sut = new Position(10, 10);
            var anotherPosition = new Position(10, 10);

            var result = sut.Equals(anotherPosition);

            result.Should().BeTrue();
        }

        [Fact]
        public void Given_DifferentPositions_Should_ReturnFalse()
        {
            var sut = new Position(10, 5);
            var anotherPosition = new Position(5, 10);

            var result = sut.Equals(anotherPosition);

            result.Should().BeFalse();
        }
    }
}