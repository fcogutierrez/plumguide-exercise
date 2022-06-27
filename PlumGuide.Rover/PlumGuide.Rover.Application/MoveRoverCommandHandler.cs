using PlumGuide.Rover.Application.Commands;
using PlumGuide.Rover.Core;

namespace PlumGuide.Rover.Application
{
    public sealed class MoveRoverCommandHandler
    {
        public MoveRoverCommandHandler(Grid grid)
        {
            
        }

        public Grid Grid { get; }

        public void Handle(MoveRoverCommand command)
        {

        }
    }
}
