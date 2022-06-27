using PlumGuide.SpaceExploration.Application.Commands;
using PlumGuide.SpaceExploration.Core;

namespace PlumGuide.SpaceExploration.Application
{
    public sealed class MoveRoverCommandHandler
    {
        public MoveRoverCommandHandler(Grid grid)
        {
            if (grid is null)
            {
                throw new ArgumentNullException(nameof(grid));
            }

            Grid = grid;
        }

        public Grid Grid { get; }

        public void Handle(MoveRoverCommand command)
        {
            foreach (var instruction in command.RoadMap)
            {
                switch (instruction)
                {
                    case 'F':
                        Grid.Rover.MoveForward();
                        break;
                    case 'B':
                        Grid.Rover.MoveBackward();
                        break;
                    case 'L':
                        Grid.Rover.TurnLeft();
                        break;
                    case 'R':
                        Grid.Rover.TurnRight();
                        break;
                    default:
                        throw new NotSupportedException($"The introduced instruction {instruction} is not supported");
                }
            }
        }
    }
}
