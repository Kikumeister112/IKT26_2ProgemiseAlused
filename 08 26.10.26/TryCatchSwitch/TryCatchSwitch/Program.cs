namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try Catch Switch");

            try
            {
                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("valisid 1");
                        break;

                    case 2:
                        Console.WriteLine("Valisid 2");
                        break;

                }

            }

            //vormi viga
            catch (FormatException)
            {
                Console.WriteLine("Paln sisesta number");
                catch
            {
                Console.WriteLine("nmber on liiga suur");
            }

        
        }
    }
}
