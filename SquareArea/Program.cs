namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int Length = int.Parse(input);
            int Area = Length * Length;
            Console.WriteLine(Area);
        }
    }
}