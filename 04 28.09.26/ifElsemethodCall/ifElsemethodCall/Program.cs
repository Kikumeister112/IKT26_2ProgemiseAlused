namespace ifElsemethodCall
{
    internal class Program
    {
        //See on meetod Main
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else
            //kui kasutaja soovib, siis saab ta meetodi välja kutsuda
            Console.WriteLine("Kui soovid meedotit välja kutsuda, siis kirjuta ja");

            static void Main(string[] args)
            {
                Console.WriteLine("Hello, World!");

                Console.WriteLine("Kui soovid meetodit välja kutsuda, siis kirjuta \"ja\":");
                string vastus = Console.ReadLine();

                if (vastus == "ja")
                {
                    MinuMeetod();
                }
                else
                {
                    Console.WriteLine("Meetodit ei kutsutud välja.");
                }
            }

            static void MinuMeetod()
            {
                Console.WriteLine("Meetod kutsuti välja!");
            }

        }

        //tehke uus meetod nimega HelloMethod
        // kirjutage sinna sisse kood, mis kuvab teksti Hello Kitty
        static void HelloKitty()
        {
            Console.WriteLine("Hello Kitty");
        } 
        

    }
}
