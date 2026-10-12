namespace Switchrandomnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Genereerb numbreid ühest kuni kuueni");

            //genereerib juhuslikke nmbreid 1 kuni 0
            int randomnumber = new Random().Next(1, 7);

            //kasutada switchi
            //peab kontrollima tulemust ja kuvamavastavat sõnumit
            switch (randomnumber)
            {
            case 1:
                Console.WriteLine("Sa said numbri 1!");
                break;
            case 2:
                Console.WriteLine("Sa said numbri 2!");
                break;
            case 3:
                Console.WriteLine("Sa said numbri 3!");
                break;
            case 4:
                Console.WriteLine("Sa said numbri 4!");
                break;
            case 5:
                Console.WriteLine("Sa said numbri 5!");
                break;
            case 6:
                Console.WriteLine("Sa said numbri 6!");
                break;
            default:
                Console.WriteLine("Tundmatu number!");
                break;
                    }




            }
    }
}
