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
            var expectedException = Record.Exception(() => new Rover(default, Facing.North));

            expectedException.Should().BeAssignableTo<ArgumentNullException>();
        }
    }
}