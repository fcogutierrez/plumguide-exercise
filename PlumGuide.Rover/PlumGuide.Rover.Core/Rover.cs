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

        public Position Position { get; private set; }
        public Facing Facing { get; }

        public void MoveForward()
        {
            var newX = Position.X;
            var newY = Position.Y;

            switch (Facing)
            {
                case Facing.North:
                    newY = Position.Y + 1;
                    break;
                case Facing.South:
                    newY = Position.Y - 1;
                    break;
                case Facing.East:
                    newX = Position.X + 1;
                    break;
                case Facing.West:
                    newX = Position.X - 1;
                    break;
            }

            var newPosition = new Position(newX, newY);
            Position = newPosition;
        }

        public void MoveBackward()
        {
            var newX = Position.X;
            var newY = Position.Y;

            switch (Facing)
            {
                case Facing.North:
                    newY = Position.Y - 1;
                    break;
                case Facing.South:
                    newY = Position.Y + 1;
                    break;
                case Facing.East:
                    newX = Position.X - 1;
                    break;
                case Facing.West:
                    newX = Position.X + 1;
                    break;
            }

            var newPosition = new Position(newX, newY);
            Position = newPosition;
        }

        public void Move(Direction direction)
        {
            var newX = Position.X;
            var newY = Position.Y;

            switch (Facing)
            {
                case Facing.North:
                    newY = direction == Direction.Forward ? Position.Y + 1 : Position.Y - 1;
                    break;
                case Facing.South:
                    newY = direction == Direction.Forward ? Position.Y - 1 : Position.Y + 1;
                    break;
                case Facing.East:
                    newX = direction == Direction.Forward ? Position.X + 1 : Position.X - 1;
                    break;
                case Facing.West:
                    newX = direction == Direction.Forward ? Position.X - 1 : Position.X + 1;
                    break;
            }

            var newPosition = new Position(newX, newY);
            Position = newPosition;
        }
    }
}