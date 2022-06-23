namespace PlumGuide.Rover.Core
{
    public sealed class Position
    {
        public Position(int x, int y)
        {
            if (x < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(x));
            }

            if (y < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(y));
            }
        }

        public int X { get; }
        public int Y { get; }
    }
}