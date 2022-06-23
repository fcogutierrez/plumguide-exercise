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

            X = x;
            Y = y;
        }

        public int X { get; }
        public int Y { get; }

        public override bool Equals(object? obj)
        {
            if (obj is null)
            {
                return false;
            }

            if (obj is not Position)
            {
                return false;
            }

            var other = (Position)obj;
            var result = (X == other.X) && (Y == other.Y);

            return result;
        }
    }
}