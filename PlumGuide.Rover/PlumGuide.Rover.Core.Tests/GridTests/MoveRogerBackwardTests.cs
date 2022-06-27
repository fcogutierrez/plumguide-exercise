﻿using FluentAssertions;
using PlumGuide.Rover.Core.Enums;
using PlumGuide.Rover.Core.Exceptions;
using Xunit;

namespace PlumGuide.Rover.Core.Tests.GridTests
{
    public sealed class MoveRogerBackwardTests
    {
        [Theory]
        [InlineData(Facing.North, 5, 0)]
        [InlineData(Facing.South, 5, 49)]
        [InlineData(Facing.East, 0, 5)]
        [InlineData(Facing.West, 49, 5)]
        public void Given_RoverInAValidPosition_Should_ThrowAMoveNotAllowedExceptionIfTheNewPositionIsNotAllowed(Facing facing, int currentX, int currentY)
        {
            var rover = new Rover(new Position(currentX, currentY), facing);
            var grid = new Grid(50, 50, rover);

            var expectedException = Record.Exception(() => grid.MoveRoverBackward());

            expectedException.Should().BeAssignableTo<MoveNotAllowedException>();
        }
    }
}