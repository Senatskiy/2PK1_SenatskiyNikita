namespace pz_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string box = "";
            string text = Console.ReadLine();
            while (text != "exit")
            {
                string result;
                result = box + text;
                box = result;
                Console.WriteLine(result);
                text = Console.ReadLine();
            }
        }
    }
}