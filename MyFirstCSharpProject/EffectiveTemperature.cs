using System;

namespace MyFirstCSharpProject
{
    class EffectiveTemperature
    {
        public void PrintEffectiveTemperature(double temperatureInCelsius, double speedInMpS)
        {
            double temperatureInFahrenheit = temperatureInCelsius * 1.8 + 32;
            double speedInMpH = speedInMpS * 2.25;
            double effectiveTemperature = 35.74 + 0.6215 * temperatureInFahrenheit +
                                          (0.4275 * temperatureInFahrenheit - 35.75) * Math.Pow(speedInMpH, 0.16);
            Console.WriteLine(effectiveTemperature);

            if (Math.Abs(temperatureInFahrenheit) > 50 || speedInMpH < 3 || speedInMpH > 120)
            {
                Console.WriteLine("Data might be incorrect");
            }
        }
    }
}
