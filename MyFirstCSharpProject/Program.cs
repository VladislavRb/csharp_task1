using System;
using System.Linq;
using System.Runtime.CompilerServices;
using Console = System.Console;

namespace MyFirstCSharpProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //each commented block of code corresponds to every task



            Console.Write("temperature (celsius): ");
            double temperatureInCelsius = Convert.ToDouble(Console.ReadLine());
            
            Console.Write("speed (m/s): ");
            double speedInMpS = Convert.ToDouble(Console.ReadLine());

            (new EffectiveTemperature()).PrintEffectiveTemperature(temperatureInCelsius, speedInMpS);



            /*Console.Write("start: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("end: ");
            int b = Convert.ToInt32(Console.ReadLine());

            (new NumbersWithFourOnes()).PrintNumbersWithFourOnes(a, b);*/



            /*Console.Write("digits string: ");
            String digitsString = Console.ReadLine();

            (new ISBN()).Print_ISBN(digitsString);*/
        }
    }
}
