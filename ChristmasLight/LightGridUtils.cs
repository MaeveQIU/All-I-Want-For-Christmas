using System.Collections.Generic;
using System.Linq;

namespace ChristmasLight
{
    public static class LightGridUtils
    {
        
        public static List<Light> LightGrid { get; set; } = InitLightGrid();

        private static List<Light> InitLightGrid()
        {
            var lightGrid = new List<Light>();
            for (var i = 0; i < 1000; i++)
            {
                for (var j = 0; j < 1000; j++)
                {
                    var light = new Light((i, j));
                    lightGrid.Add(light);
                }
            }

            return lightGrid;
        }

        public static void TurnOn((int positionX, int positionY) coordinate)
        {
            LightGrid.Where(x => x.Coordinate.PositionX == coordinate.positionX && x.Coordinate.PositionY == coordinate.positionY)
                .ToList()
                .ForEach(x => x.TurnOnLight());
        }
        
        public static void TurnOff((int positionX, int positionY) coordinate)
        {
            LightGrid.Where(x => x.Coordinate.PositionX == coordinate.positionX && x.Coordinate.PositionY == coordinate.positionY)
                .ToList()
                .ForEach(x => x.TurnOffLight());
        }
        
        public static void Toggle((int positionX, int positionY) coordinate)
        {
            LightGrid.Where(x => x.Coordinate.PositionX == coordinate.positionX && x.Coordinate.PositionY == coordinate.positionX)
                .ToList()
                .ForEach(x => x.ToggleLight());
        }
    }
}