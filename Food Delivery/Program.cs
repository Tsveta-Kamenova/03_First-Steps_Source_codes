namespace Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veggie = int.Parse(Console.ReadLine());
            double delivery = 2.50;
            double chickenPrice = 10.35;
            double fishPrice = 12.40;
            double veggiePrice = 8.15;
            double sumDishes = (chicken * chickenPrice) + (fish * fishPrice) + (veggie * veggiePrice);
            double dessert = 0.2 * sumDishes;
            double sumToPay = delivery+dessert+sumDishes;
            Console.WriteLine(sumToPay);
        }
    }
}