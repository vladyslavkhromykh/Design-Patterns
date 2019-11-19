using System.Drawing;

namespace Flyweight
{
    internal class PlayerSharedData
    {
        public readonly int MinimalSpeed;
        public readonly int MaximalSpeed;
        public readonly Point StartLocation;
        public readonly Point TargetLocation;
        public readonly string GuestName;

        public PlayerSharedData(int minimalSpeed, int maximalSpeed, Point startLocation, Point targetLocation)
        {
            this.MinimalSpeed = minimalSpeed;
            this.MaximalSpeed = maximalSpeed;
            this.StartLocation = startLocation;
            this.TargetLocation = targetLocation;
            this.GuestName = string.Concat("Guest user");
        }
    }
}