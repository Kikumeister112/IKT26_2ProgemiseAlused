namespace ifAndelseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            bool vihmaSajab = true;
            bool vihmavariOn = false;

            if (vihmaSajab)
            {
                Console.WriteLine("Väljas sajab vihma.");
            }
           if (vihmavariOn)
            {
                if (true)
                {
                    Console.WriteLine("Vihmavari on olemas.");
                }
                else
                {
                    Console.WriteLine("Vihmavari puudub.");
                }
            }
            else
            {
                Console.WriteLine("Vihma ei saja.");
            }
        }
    }
}
