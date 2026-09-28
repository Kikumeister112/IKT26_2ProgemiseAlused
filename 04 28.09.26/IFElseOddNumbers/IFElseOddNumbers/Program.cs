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


            if (number % 2 == 0)
            {
                EvenNumber();
            }
            else
            {
                oddnumbers();
            }
        }

        static void EvenNumber()
        {
            Console.WriteLine("Paarisarv");
        }


        static void oddnumbers()
        {
            Console.WriteLine("Paaritud");
        }
    }
}

