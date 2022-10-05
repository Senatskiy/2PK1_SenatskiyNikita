<<<<<<< HEAD
﻿namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = 5, mult = 1;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(0, 10);
                    Console.Write(string.Format("{0,2} ", a[i, j]));
                }
                Console.WriteLine();
            }

            for (int i = 0; i < n; i++)
                if (a[i, i] > 0)
                    mult *= a[i, i];

            Console.Write("произведение = {0}", mult);
            Console.ReadLine();

        }
    }
}\
=======
﻿namespace pz_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int n = 5, mult = 1;
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    a[i, j] = rand.Next(0, 10);
                    Console.Write(string.Format("{0,2} ", a[i, j]));
                }
                Console.WriteLine();

            }

            for (int i = 0; i < n; i++)
                if (a[i, i] > 0)
                    mult *= a[i, i];

            Console.Write("произведение = {0}", mult);
            Console.ReadLine();

        }
    }
}
>>>>>>> 19 Вариант
