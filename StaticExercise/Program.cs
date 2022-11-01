namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What temp would you like to convert?");
            var celTemp = Convert.ToDouble(Console.ReadLine());
            double convertToCel = TempConverter.FahrenheitToCelsius(celTemp);
            Console.WriteLine(convertToCel);

            Console.WriteLine("What temp would you like to convert?");
            var fahTemp = Convert.ToDouble(Console.ReadLine());
            double convertToFah = TempConverter.CelsiusToFahrenheit(fahTemp);
            Console.WriteLine(convertToFah);
        }
    }
}
