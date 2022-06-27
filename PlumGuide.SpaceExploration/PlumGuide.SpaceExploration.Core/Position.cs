namespace PlumGuide.SpaceExploration.Core
{
    public sealed class Position
    {
        public Position(int x, int y)
        {
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

            if (obj is not Position other)
            {
                return false;
            }

            var result = (X == other.X) && (Y == other.Y);

            return result;
        }
    }
}