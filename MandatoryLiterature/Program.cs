namespace MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesToRead = int.Parse(Console.ReadLine());
            int speed = int.Parse(Console.ReadLine());
            int daysToFinish = int.Parse(Console.ReadLine());
            int time = pagesToRead / speed;
            int hoursADay = time/ daysToFinish;
            Console.WriteLine(hoursADay);
        }
    }
}