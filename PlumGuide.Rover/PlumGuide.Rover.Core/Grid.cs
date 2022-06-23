namespace PlumGuide.Rover.Core
{
    public sealed class Grid
    {
        public Grid(int width, int height)
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
        }

        public int Width { get; }
        public int Height { get; }

        public bool CanMoveToPosition(Position position)
        {
            throw new NotImplementedException();
        }
    }
}