namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.Write($"Fahrentheit -> Celcius: {TempConverter.FahrenheitToCelsius(32)}");           
            Console.WriteLine();

            Console.Write($"Celcius -> Fahrentheit: {TempConverter.CelsiusToFahrenheit(0)} ");
            Console.WriteLine();

        }
    }
}
