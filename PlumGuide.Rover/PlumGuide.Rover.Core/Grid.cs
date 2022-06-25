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

            if (rover.Position.X < 0 || 
                rover.Position.X > width - 1 ||
                rover.Position.Y < 0 ||
                rover.Position.Y > height - 1)
            {
                throw new ArgumentException(nameof(rover));
            }

            Width = width;
            Height = height;
            Rover = rover;
        }

        public int Width { get; }
        public int Height { get; }
        public Rover Rover { get; }
    }
}