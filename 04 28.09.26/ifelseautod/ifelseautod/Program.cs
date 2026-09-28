namespace ifelseautod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            //kasutada if ja else
            //kirjuta automark
            //valikus on BMW, audi, porsche ja skoda
            //Kui valitakse škoda, siis seal sees on uuesti küsimus,et
            //mis mudelit soovid valida. Mudeli valikus kodiaq ja Octavia

            Console.WriteLine("vali enda auto:");
            Console.WriteLine("BMW");
            Console.WriteLine("Audi");
            Console.WriteLine("Porsche");
            Console.WriteLine("Skoda");

            string automark = Console.ReadLine();

            if (automark == "BMW")
            {
                Console.WriteLine("Valisid BMW.");

            }
            else if (automark == "Audi")
            {
                Console.WriteLine("Valisid Audi.");
            }
            else if (automark == "Porsche")
            {
                Console.WriteLine("Valisid Porsche.");
            }
            else if (automark == "Skoda") ;
            {
                Console.WriteLine("Mis mudelit soovite? ´Kodiaqi või Octaviat");
                string škodamudel = Console.ReadLine();
                Console.WriteLine("valisid "+škodamudel );
            }
            
            

        }
    }
}
