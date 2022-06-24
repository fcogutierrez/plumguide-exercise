using PlumGuide.Rover.Core.Enums;

namespace PlumGuide.Rover.Core
{
    public sealed class Rover
    {
        public Rover(Position position, Facing facing)
        {
            if (position is null)
            {
                throw new ArgumentNullException(nameof(position));
            }

            Position = position;
            Facing = facing;
        }

        public Position Position { get; }
        public Facing Facing { get; }

        public void Move(Direction direction)
        {
        }
    }
}