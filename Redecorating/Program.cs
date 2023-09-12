namespace Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = 2+double.Parse(Console.ReadLine());
            double paint = 1.1*double.Parse(Console.ReadLine());
            double paintThinner = double.Parse(Console.ReadLine());
            double hoursWork = double.Parse(Console.ReadLine());
            double bags = 0.40;
            double nylonPrice = 1.50;
            double paintPrice = 14.5;
            double paintThinnerPrice = 5.0;
            double sumMaterials = (nylon * nylonPrice) + (paint * paintPrice) + (paintThinner * paintThinnerPrice) + bags;
            double payment = 0.3 * sumMaterials*hoursWork;
            double sumToPay = payment+sumMaterials;
            Console.WriteLine(sumToPay);
        }
    }
}