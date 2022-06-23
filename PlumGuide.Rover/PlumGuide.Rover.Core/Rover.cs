using PlumGuide.Rover.Core.Enums;

namespace PlumGuide.Rover.Core
{
    public sealed class Rover
    {
        public Rover(Position position, Facing facing)
        {
            if (position == null)
            {
                throw new ArgumentNullException(nameof(position));
            }
        }

        public Position Position { get; }
        public Facing Facing { get; }
    }
}
