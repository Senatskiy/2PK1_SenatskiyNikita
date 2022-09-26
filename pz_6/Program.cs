namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 1;
            while (x <= 3)
            {
                double y = 8 * x + 4 * Math.Pow(x, 4) - 1.5 * Math.Pow(x, 3);
                x += 0.2;
                Console.WriteLine(y);
            }
        }
    }
}