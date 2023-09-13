namespace AnimalTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string animal = Console.ReadLine();
            //if (animal == "dog")
            //{
            //    Console.WriteLine("mammal");
            //}
            //else if (animal == "crocodile" || animal == "tortoise" || animal == "snake")
            //{
            //    Console.WriteLine("reptile");
            //}
            //else
            //{
            //    Console.WriteLine("unknown");
            //}
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal"); break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile"); break;
                default:
                    Console.WriteLine("unknown"); break;
            }
        }
    }
}