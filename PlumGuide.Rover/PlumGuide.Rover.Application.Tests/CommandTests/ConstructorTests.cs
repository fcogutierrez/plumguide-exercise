using FluentAssertions;
using PlumGuide.Rover.Application.Commands;
using Xunit;

namespace PlumGuide.Rover.Application.Tests.CommandTests
{
    public sealed class ConstructorTests
    {
        [Fact]
        public void Given_MissingRoadMap_Should_ThrowAnArgumentNullException()
        {
            var expectedException = Record.Exception(() => new MoveRoverCommand(default));

            expectedException.Should().BeAssignableTo<ArgumentNullException>();
        }

        [Fact]
        public void Given_RoadMap_Should_AssignIt()
        {
            var sut = new MoveRoverCommand("ABC");

            sut.RoadMap.Should().Be("ABC");
        }
    }
}
