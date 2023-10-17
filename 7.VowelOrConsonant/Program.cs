namespace _7.VowelOrConsonant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter = char.Parse(Console.ReadLine() ?? "A");

            letter = char.ToUpper(letter);

            switch (letter)
            {
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("Vowel"); break;
                default:
                    Console.WriteLine("Consonant"); break;
            }
        }
    }
}