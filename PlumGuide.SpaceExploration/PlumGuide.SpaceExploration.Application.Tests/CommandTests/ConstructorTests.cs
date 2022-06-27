using FluentAssertions;
using PlumGuide.SpaceExploration.Application.Commands;
using Xunit;

namespace PlumGuide.SpaceExploration.Application.Tests.CommandTests
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
