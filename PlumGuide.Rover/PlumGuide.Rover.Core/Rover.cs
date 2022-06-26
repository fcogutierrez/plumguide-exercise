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
        public Facing Facing { get; private set; }

        public void MoveForward()
        {
            var newPosition = GetPositionAfterMovingForward();
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
                default:
                    throw new InvalidOperationException();
            }

            var newPosition = new Position(newX, newY);
            Position = newPosition;
        }

        public Position GetPositionAfterMovingForward()
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
                default:
                    throw new InvalidOperationException();
            }

            var position = new Position(newX, newY);
            return position;
        }

        public void TurnRight()
        {
            switch (Facing)
            {
                case Facing.North:
                    Facing = Facing.East;
                    break;
                case Facing.East:
                    Facing = Facing.South;
                    break;
                case Facing.South:
                    Facing = Facing.West;
                    break;
                case Facing.West:
                    Facing = Facing.North;
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }

        public void TurnLeft()
        {
            switch (Facing)
            {
                case Facing.North:
                    Facing = Facing.West;
                    break;
                case Facing.West:
                    Facing = Facing.South;
                    break;
                case Facing.South:
                    Facing = Facing.East;
                    break;
                case Facing.East:
                    Facing = Facing.North;
                    break;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}