namespace SwitchBetweenNumbers
{
    internal class Program
    {

        static void Main()
        {
            Console.Write("Sisesta number: ");
            string sisend = Console.ReadLine();

            int number = int.Parse(sisend);

            switch (number)
            {
                case >= 0 and <= 100:
                    Console.WriteLine("Esimene koondtulemus");
                    break;

                case >= 101 and <= 200:
                    Console.WriteLine("Teine koondtulemus");
                    break;

                case >= 201 and <= 300:
                    Console.WriteLine("Kolmas koondtulemus");
                    break;

                default:
                    Console.WriteLine("Number peab olema vahemikus 0 kuni 300!");
                    break;


            }
        }
    }
}
