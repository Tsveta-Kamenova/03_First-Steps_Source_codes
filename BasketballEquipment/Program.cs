namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int trainingFee = int.Parse(Console.ReadLine());

            double sneakers = 0.6*trainingFee;
            double team = 0.8*sneakers;
            double basketball = team/4;
            double accessories = basketball/5;
            double sumToPay = sneakers+team+basketball+accessories+trainingFee;
            Console.WriteLine(sumToPay);
        }
    }
}