namespace ConsoleConverterUSDtoBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dollar = double.Parse(Console.ReadLine());
            double bgn = 1.79549;
            Console.WriteLine(dollar*bgn);
        }
    }
}