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

        public (int PositionX, int PositionY) Coordinate { get; }
        
        public bool IsOn { get; set; }

        public void TurnOnLight() => IsOn = true;

        public void TurnOffLight() => IsOn = false;

        public void ToggleLight() => IsOn = !IsOn;
    }
}