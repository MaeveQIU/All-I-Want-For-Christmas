using System;

namespace ChristmasLight
{
    public class Light
    {
        public Light((int PositionX, int PositionY) coordinate, bool isOn = false)
        {
            Coordinate = coordinate;
            IsOn = isOn;
        }

        public (int PositionX, int PositionY) Coordinate { get; set; }
        
        public bool IsOn { get; set; }

    }
}