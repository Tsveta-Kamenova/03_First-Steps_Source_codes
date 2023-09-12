namespace TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pens = double.Parse(Console.ReadLine());
            double markers = double.Parse(Console.ReadLine());
            double boardCleaner = double.Parse(Console.ReadLine());
            double pensPrice = 5.80;
            double markersPrice = 7.20;
            double boardCleanerPrice = 1.20;
            double discount = double.Parse(Console.ReadLine());
            double sum = (pens*pensPrice + markers*markersPrice + boardCleaner*boardCleanerPrice);
            double discountSum = sum * discount/100;
            double sumToPay = sum - discountSum;
            Console.WriteLine(sumToPay);
        }
    }
}