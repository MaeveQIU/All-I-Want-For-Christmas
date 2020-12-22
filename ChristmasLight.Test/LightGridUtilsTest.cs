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
           Assert.Equal(0, _lightGrid[0].Coordinate.PositionX);
           Assert.Equal(0, _lightGrid[0].Coordinate.PositionY);
           
           Assert.Equal(999, _lightGrid[999].Coordinate.PositionX);
           Assert.Equal(0, _lightGrid[999].Coordinate.PositionY);
           
           Assert.Equal(0, _lightGrid[_lightGrid.Count - 1000].Coordinate.PositionX);
           Assert.Equal(999, _lightGrid[_lightGrid.Count - 1000].Coordinate.PositionY);
           
           Assert.Equal(999, _lightGrid[_lightGrid.Count - 1].Coordinate.PositionX);
           Assert.Equal(999, _lightGrid[_lightGrid.Count - 1].Coordinate.PositionY);
        }

        [Fact]
        void should_only_set_the_first_line_of_lights_on()
        {
            LightGridUtils.TurnOn((0, 0), (999, 0));
            
            Assert.True(_lightGrid[0].IsOn);
            Assert.True(_lightGrid[500].IsOn);
            Assert.True(_lightGrid[999].IsOn);
            Assert.False(_lightGrid[1000].IsOn);
        }

        [Fact]
        void should_turn_off_the_first_five_hundred_lights()
        {
            LightGridUtils.TurnOn((0, 0), (999, 0));
            LightGridUtils.TurnOff((0, 0), (499, 0));
            
            Assert.False(_lightGrid[0].IsOn);
            Assert.False(_lightGrid[499].IsOn);
            Assert.True(_lightGrid[500].IsOn);
        }
        
        [Fact]
        void should_toggle_light_on_or_off()
        {
            LightGridUtils.TurnOff((0, 0), (999, 999));
            LightGridUtils.TurnOn((0, 0), (999, 0));
            LightGridUtils.Toggle((0, 0), (499, 0));
            
            Assert.False(_lightGrid[0].IsOn);
            Assert.False(_lightGrid[499].IsOn);
            Assert.True(_lightGrid[500].IsOn);
            Assert.True(_lightGrid[999].IsOn);
        }

        [Fact]
        void should_have_one_thousand_lights_lit()
        {
            LightGridUtils.TurnOn((0, 0), (999, 0));
            Assert.Equal(1000, LightGridUtils.CountLitLights());
        }
        
    }
}