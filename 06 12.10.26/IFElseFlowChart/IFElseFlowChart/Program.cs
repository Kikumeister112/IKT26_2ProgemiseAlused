using System.Threading.Channels;

namespace IFElseFlowChart
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if ja else");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("you entered 1");

            }
            else if (input == "2")
            {
                Console.WriteLine("You entered 2");
            }
            else
            {
                Console.WriteLine("You entered something else");
            }


        }
    }
}
