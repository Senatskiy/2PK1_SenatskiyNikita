namespace Pz_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 60;
            for (; a <= b; a+=3)
            {
                Console.WriteLine(a.ToString());
            }
            Console.WriteLine("Первое задание выполнено");
            {
                char f = 'Д';
                for (int i = 0; i <= 6; i++)
                {
                    Console.WriteLine(f);
                    f++;
                }
                Console.WriteLine("Второе задание выполнено");
            }
            for (var i = 0; i <= 8; i++)
            {
                for (var j = 0; j < 5; j++)
                {
                    Console.Write('#');
                }
                Console.WriteLine();
            }
            Console.WriteLine("Третье задание выполнено");
            {
                for (int i = 0; i <= 100; i++)
                    if (i % 3.5 == 0) Console.WriteLine(i);
            }
            Console.WriteLine("Четвертое задание выполнено");
            {
                for (int i = 5, j = 82; i - j != 35; i++, j--)
                {
                    Console.WriteLine(i + "  " + j);
                }
                Console.WriteLine("Пятое задание выполнено");


            }
        }
    }
}