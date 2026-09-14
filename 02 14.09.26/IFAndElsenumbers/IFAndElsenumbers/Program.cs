namespace IFAndElsenumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kirjuta enda vanus");

            //peate kasutama if and else lauseid,
            //et kontrollida, kas kasutaja vanus
            //on suurem kui 18 või väiksem kui 18





            string userInput = Console.ReadLine();
            int userage = int.Parse(userInput);

            if (userage >= 18)
            {
                Console.WriteLine("Sa oled täisealine");
            }
            else
            {
                Console.WriteLine("Sa oled alaealine");
            }

        }        
    }
}


            