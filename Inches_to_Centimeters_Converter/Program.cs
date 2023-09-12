namespace Inches_to_Centimeters_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double inches = double.Parse(input);
            double centimeters = inches * 2.54;
            Console.WriteLine(centimeters);
        }
    }
}