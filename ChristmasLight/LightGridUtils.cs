using System.Collections.Generic;

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
                    var light = new Light(i, j);
                    lightGrid.Add(light);
                }
            }

            return lightGrid;
        }

    }
}