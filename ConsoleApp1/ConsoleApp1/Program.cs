using System;

namespace wrx
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] Shifer = { 'Ф', 'А', 'М', 'И', 'Л', 'И', 'Я' };
            char[] result = new char[Shifer.Length];
            Console.Write("TEXT: ");
            Console.WriteLine(Shifer);

            for (int i = 0; i < Shifer.Length; i++)
            {
                result[i] = (char)(Shifer[i] + '5');
            }
            Console.Write("SHIFR + 5: ");
            Console.WriteLine(result);

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = (char)(result[i] - 5);
            }
            Console.Write("DESHIFR - 5");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}