using Xunit;

namespace ChristmasLight.Test
{
    public class UnitTest1
    {
        [Fact]
        void should_set_light_off_as_default()
        {
            Light light = new Light(1, 1);
            Assert.False(light.IsOn);
        }
    }
}