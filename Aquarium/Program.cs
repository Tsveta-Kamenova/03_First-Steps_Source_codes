namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());

            double volume = (width * length * height)*0.001;
            double occupiedSpace = percentage*0.01;
            double usefulVolume = volume*(1-occupiedSpace);
            Console.WriteLine(usefulVolume);
        }
    }
}