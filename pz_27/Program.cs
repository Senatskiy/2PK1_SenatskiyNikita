using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_27
{
    struct ZNAK
    {
        public string NAME; 
        public string ZODIAC; 
        public int[] BDAY; 
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ZNAK[] BOOK = new ZNAK[8];
            for (int i = 0; i < BOOK.Length; i++)
            {
                Console.WriteLine($"Введите данные для записи №{i + 1}:");
                Console.Write("Имя: ");
                BOOK[i].NAME = Console.ReadLine();
                Console.Write("Знак зодиака: ");
                BOOK[i].ZODIAC = Console.ReadLine();
                BOOK[i].BDAY = new int[3];
                Console.Write("День рождения (через пробел в формате дд мм гггг): ");
                string[] bday = Console.ReadLine().Split(' ');
                BOOK[i].BDAY[0] = int.Parse(bday[0]);
                BOOK[i].BDAY[1] = int.Parse(bday[1]);
                BOOK[i].BDAY[2] = int.Parse(bday[2]);
            }
            Array.Sort(BOOK, (x, y) => DateTime.Compare(new DateTime(x.BDAY[2], x.BDAY[1], x.BDAY[0]), new DateTime(y.BDAY[2], y.BDAY[1], y.BDAY[0])));

            Console.Write("Введите название знака зодиака: ");
            string zodiac = Console.ReadLine();

            Console.WriteLine($"Информация о людях, родившихся под знаком {zodiac}:");
            foreach (ZNAK z in BOOK)
            {
                if (z.ZODIAC == zodiac)
                {
                    Console.WriteLine($"{z.NAME} - {z.BDAY[0]}.{z.BDAY[1]}.{z.BDAY[2]}");
                }
            }

            Console.ReadLine();
        }
    }
}
