using System.Collections.Generic;
using System.Linq;

namespace ChristmasLight
{
    public static class LightGridUtils
    {
        public static List<Light> LightGrid { get; } = InitLightGrid();

        private static List<Light> InitLightGrid()
        {
            var lightGrid = new List<Light>();
            for (var i = 0; i < 1000; i++)
            {
                for (var j = 0; j < 1000; j++)
                {
                    var light = new Light((j, i));
                    lightGrid.Add(light);
                }
            }

            return lightGrid;
        }

        private static List<Light> FindLights((int positionX, int positionY) coordinateStart,
            (int positionX, int positionY) coordinateEnd)
        {
            return LightGrid.Where(x => x.Coordinate.PositionX >= coordinateStart.positionX &&
                                        x.Coordinate.PositionX <= coordinateEnd.positionX
                                        && x.Coordinate.PositionY >= coordinateStart.positionY &&
                                        x.Coordinate.PositionY <= coordinateEnd.positionY)
                .ToList();
        }

        public static void TurnOn((int positionX, int positionY) coordinateStart,
            (int positionX, int positionY) coordinateEnd) =>
            FindLights(coordinateStart, coordinateEnd).ForEach(x => x.TurnOnLight());


        public static void TurnOff((int positionX, int positionY) coordinateStart,
            (int positionX, int positionY) coordinateEnd) =>
            FindLights(coordinateStart, coordinateEnd).ForEach(x => x.TurnOffLight());


        public static void Toggle((int positionX, int positionY) coordinateStart,
            (int positionX, int positionY) coordinateEnd) =>
            FindLights(coordinateStart, coordinateEnd).ForEach(x => x.ToggleLight());
    }
}