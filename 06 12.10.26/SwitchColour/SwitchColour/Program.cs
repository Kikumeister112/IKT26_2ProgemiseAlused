using System.Threading.Channels;

namespace SwitchColour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta värvi nimi!");
            //kasuta switchi
            //sisestab värvi nime
            //red, green, blue, white, orange
            //iga värvi puhul näiab vastava värviga konsooli + tekst
            //kui sisestatakse muu värv, siis näitab "värv puudub"
           
                static void Main()
            {
                
                string varv = Console.ReadLine().ToLower();

                switch (varv)
                {
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red – punane");
                        break;

                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Green – roheline");
                        break;

                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue – sinine");
                        break;

                    case "white":
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("White – valge");
                        break;

                    case "orange":
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("Orange – oranž");
                        break;

                    default:
                        Console.WriteLine("värv puudub");
                        break;
                }

                
            }
        }
    }
    }

