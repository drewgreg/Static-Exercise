namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsuis(68);
            Console.WriteLine($"Temp in celsius is {celsius}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"Temp in fahrenheit is {fahrenheit}");
        }
    }
}
