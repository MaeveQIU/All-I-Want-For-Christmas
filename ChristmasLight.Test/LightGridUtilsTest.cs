using System.Collections.Generic;
using Xunit;

namespace ChristmasLight.Test
{
    public class LightGridUtilsTest
    {
        
        private readonly List<Light> _lightGrid = LightGridUtils.LightGrid;

        [Fact]
        void should_contain_one_million_lights_in_light_grid()
        {
            Assert.Equal(1000000, _lightGrid.Count);
        }

        [Fact]
        void should_return_the_right_coordinate_for_four_corners()
        {
           Assert.Equal(0, _lightGrid[0].PositionX);
           Assert.Equal(0, _lightGrid[0].PositionY);
           
           Assert.Equal(0, _lightGrid[999].PositionX);
           Assert.Equal(999, _lightGrid[999].PositionY);
           
           Assert.Equal(999, _lightGrid[_lightGrid.Count - 1000].PositionX);
           Assert.Equal(0, _lightGrid[_lightGrid.Count - 1000].PositionY);
           
           Assert.Equal(999, _lightGrid[_lightGrid.Count - 1].PositionX);
           Assert.Equal(999, _lightGrid[_lightGrid.Count - 1].PositionY);
        }

        [Fact]
        void should_set_light_on_then_set_light_off()
        {
            LightGridUtils.TurnOnLight(999, 999);
            Assert.True(_lightGrid[_lightGrid.Count - 1].IsOn);
            
            LightGridUtils.TurnOffLight(999, 999);
            Assert.False(_lightGrid[_lightGrid.Count - 1].IsOn);
        }
        
        [Fact]
        void should_toggle_light_on_and_off()
        {
            LightGridUtils.ToggleLight(999, 999);
            Assert.True(_lightGrid[_lightGrid.Count - 1].IsOn);
            
            LightGridUtils.ToggleLight(999, 999);
            Assert.False(_lightGrid[_lightGrid.Count - 1].IsOn);
        }
        
    }
}