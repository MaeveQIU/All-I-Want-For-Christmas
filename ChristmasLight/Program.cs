using System;

namespace ChristmasLight
{
    class Program
    {
        static void Main(string[] args)
        {
            LightGridUtils.TurnOn((0, 0), (999, 999));
            LightGridUtils.Toggle((0, 0), (999, 0));
            LightGridUtils.TurnOff((499, 499), (500, 500));
            var count = LightGridUtils.CountLitLights();
            
            Console.WriteLine("{0} lights are lit", count);
        }
    }
}