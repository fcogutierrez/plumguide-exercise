namespace PlumGuide.Rover.Application.Commands
{
    public class MoveRoverCommand
    {
        public MoveRoverCommand(string roadMap)
        {
            if (string.IsNullOrWhiteSpace(roadMap))
            {
                throw new ArgumentNullException(nameof(roadMap));
            }
        }

        public string RoadMap { get; }
    }
}
