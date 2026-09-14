namespace IFAndElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta enda nimi");

            // siin on muutuja nimega name,
            // mis on tüübiga string 
            // loeb andmeid konsoolist ja salvestab
            // need muutuja name sisse
            string name = Console.ReadLine();
            //if ja else kontrollib, kas muutuja
            //name on tühi või mitte

            //kui muutuja name on tühi, siis väljastab konsoolile
            //teksti "tere, tudmatu! ERROR" ja teeb 4 piiksu
            if (name != "")
            {
                Console.WriteLine("tere, " + name);
            }

            else
            {
                Console.WriteLine("Tere, tundmatu! ERROR");
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
                Thread.Sleep(1000);
                Console.Beep();
               

            }
        }
    }
}


