using PlumGuide.Rover.Core.Exceptions;

namespace PlumGuide.Rover.Core
{
    public sealed class Grid
    {
        public Grid(int width, int height, Rover rover)
        {
            if (width < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(width));
            }

            if (height < 1)
            {
                throw new ArgumentOutOfRangeException(nameof(height));
            }

            Width = width;
            Height = height;

            if (!IsValidPosition(rover.Position))
            {
                throw new ArgumentException("The Rover's position is not supported", nameof(rover));
            }

            Rover = rover;
        }

        public int Width { get; }
        public int Height { get; }
        public Rover Rover { get; }

        public void MoveRoverForward()
        {
            var nextPosition = Rover.GetPositionAfterMovingForward();

            if (!IsValidPosition(nextPosition))
            {
                throw new MoveNotAllowedException();
            }

            Rover.MoveForward();
        }

        private bool IsValidPosition(Position position)
        {
            var result =
                position.X >= 0 &&
                position.X < Width &&
                position.Y >= 0 &&
                position.Y < Height;

            return result;
        }
    }
}