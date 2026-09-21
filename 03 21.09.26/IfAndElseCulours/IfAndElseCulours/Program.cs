using System.Drawing;

namespace IfAndElseCulours
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            Console.WriteLine("Teha if ja else konsoolirakendus, kus" + " kontrollitakse stringi abil värvi vastasvusr");

            Console.WriteLine(" värvide valikus on: red, blue, green ja white");
            Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta" + " eelpool sisestaud värv");
            using System;

namespace IfAndElseColours
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello, world!");
                Console.WriteLine("Sisesta värv: red, blue, green ja white");
                Console.WriteLine("Peab käsitlema juhust, kus vastaja ei sisesta värvi");

                Console.Write("Sisesta värv: ");
                string color = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(color))
                {
                    Console.WriteLine("Sa ei sisestanud värvi!");
                }
                else if (color.ToLower() == "red")
                {
                    Console.WriteLine("Sisestasid punase värvi.");
                }
                else if (color.ToLower() == "blue")
                {
                    Console.WriteLine("Sisestasid sinise värvi.");
                }
                else if (color.ToLower() == "green")
                {
                    Console.WriteLine("Sisestasid rohelise värvi.");
                }
                else if (color.ToLower() == "white")
                {
                    Console.WriteLine("Sisestasid valge värvi.");
                }
                else
                {
                    Console.WriteLine("Sellist värvi nimekirjas ei ole!");
                }
            }
        }
    }




