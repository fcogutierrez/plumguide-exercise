using FluentAssertions;
using Xunit;

namespace PlumGuide.Rover.Application.Tests.MoveRoverCommandHandlerTests
{
    public sealed class ConstructorTests
    {
        [Fact]
        public void Given_MissingGrid_Should_ThrowAnArgumentNullException()
        {
            var expectedException = Record.Exception(() => new MoveRoverCommandHandler(default));

            expectedException.Should().BeAssignableTo<ArgumentNullException>();
        }
    }
}
