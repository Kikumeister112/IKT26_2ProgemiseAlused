namespace KujundiKalkuaator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Ruudu sees asub ring. ringi raadius on 3 ühikut
            //Leia ja väljasta ekraanile ruudu pindala ja ümbermõõt

            int roundRadius = 3;
            int diameter = roundRadius * 2;
            double squareArea1 = Math.Pow(diameter, 2);
            double squareArea2 = diameter * diameter;

            double squarePerimeter = diameter * 4;

            Console.WriteLine("Ruudu pindala:" + squareArea2);
            Console.WriteLine("Ruudu ümbermõõt:" + squarePerimeter);


            //arvuta ringi pindala ja ümbermõõt

            double roundArea1 = Math.PI * Math.Pow(roundRadius, 2);
            double roundArea2 = Math.PI * (roundRadius * roundRadius);
            double roundPerimeter = 2 * Math.PI * roundRadius;

            // kuidas teha, et maksimaalselt kaks kohta pärast koma oleks
            Console.WriteLine("Ringi pindala" + Math.Round  (roundArea2,  2));
            Console.WriteLine("2Ringi pindala" + Math.Round(roundArea2));

            Console.WriteLine("Ringi ümbermõõt" + roundPerimeter);


             
        }
    }
}
