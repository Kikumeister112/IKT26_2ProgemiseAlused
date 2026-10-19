namespace Switchnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //tuleb teha switch, kus esimene case on 10, teine on 20 ja kolmas on 30.
            //küsitakse numbrit ja sisestad konsooli

            int num = int.Parse(Console.ReadLine());
            switch (num) 
            {
                case 10:
                    Console.WriteLine("Sisestasid numbri 10");
                    break;

                case 20:
                    Console.WriteLine("Sisestasid numbri 20");
                    break;

                case 30:
                    Console.WriteLine("Sisestasid numbri 30");
                    break;

                default:
                    Console.WriteLine("Sellist numbrit pole valikus!");
                    break;
            }
        }
    }
}
