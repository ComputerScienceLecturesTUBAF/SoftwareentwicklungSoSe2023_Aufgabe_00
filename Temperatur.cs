using System;

namespace TemperatureCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float fahrenheit, celsius;
            celsius = 0,
            fahrenheit = 9 / 5 * celsius + 32;
            Console.WriteLine("{0} Celsius entspricht {0} Fahrenheit", celsius, fahrenheit);
            Console.WriteLine("Celsius: ");
            celsius = Convert.ToFloat(Console.ReadLine());
            fahrenheit = 9 / 5 * celsius + 32;
            Console.WriteLine("Fahrenheit:", Fahrenheit);
        }
    }
}
