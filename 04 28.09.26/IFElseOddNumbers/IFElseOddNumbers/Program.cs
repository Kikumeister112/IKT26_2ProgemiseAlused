namespace IFElseOddNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // Konsool küsib numbrit
            Console.WriteLine("Sisesta number:");

            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Sisestasid numbri: " + number);
            static void Main(string[] args)
            {
                Console.WriteLine("Sisesta number:");

                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine("Number on paaris.");
                }
                else
                {
                    Console.WriteLine("Number on paaritu.");
                }
            }


        }
    }
}
