namespace ChristmasLight
{
    public class Light
    {
        public Light(int positionX, int positionY, bool isOn = false)
        {
            PositionX = positionX;
            PositionY = positionY;
            IsOn = isOn;
        }

        public int PositionX { get; set; }

        public int PositionY { get; set; }
        
        public bool IsOn { get; set; }

    }
}