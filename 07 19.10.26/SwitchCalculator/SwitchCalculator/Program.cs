namespace SwitchCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimene number");
            float firstNr = float.Parse(Console.ReadLine());

            //siin valitakse switchi case
            Console.WriteLine("Vali tehe: +,/, +, -");
            float input = float.Parse(Console.ReadLine());

            Console.WriteLine("Sisesta teine number");

            float secondNr = float.Parse(Console.ReadLine());


            //nüüd tuleb teha switchi valik, kas +, /, +, -
            //tuleb teha neli case, kus toimub soovitud tehe
            //peab näitama tehte tulemust
            //kasutage floati parsimisel

            switch (input)
            {
                case "+":
                    Console.WriteLine($"liitmise tulemus: {firstNr} + {secondNr}");
                    break;

                case "_":
                    Console.WriteLine($"liitmise tulemus: {firstNr} - {secondNr}");
                    break;

                case "/":
                    if (secondNr == 0)
                    Console.WriteLine($"liitmise tulemus: {firstNr} + {secondNr}");
                    break;


            }
            



        }
    }
}
