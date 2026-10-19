namespace SwitchMultipleCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string input = Console.ReadLine();

            switch (input)
            {
                case "intro to c#" or "variables" or "data types":
                    Console.WriteLine("basic");
                    break;

                case "oop" or "classes" or "objects":
                    Console.WriteLine("Advanced");
                    break;
                case "asynchronous programming" or "LTNQ" or "Delegates":

                    Console.WriteLine("advances");
                    break;


                default:
                    Console.WriteLine("unknown course");
                    break;
            }
        }
    }
}
