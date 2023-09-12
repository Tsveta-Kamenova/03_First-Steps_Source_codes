namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine()) ;
            double rate = double.Parse(Console.ReadLine()) ;
            double interest = term*deposit * rate / 100 / 12;
            double amountToReceive = deposit + interest;
            Console.WriteLine(amountToReceive);
        }
    }
}