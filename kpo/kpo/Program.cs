using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Program: Kő papír olló játék leprogramozása
            ///Irta: Tomek Martin / 2019.03.06
            ///Adott: számítógép - véletlenszerű válasz

            ///Megoldandó feladat 1:
            ///Citlus programfutatás, amíg a felhasználó szeretne játszani

            bool moreGame = true;

            Console.WriteLine("**********Kő/Papír/Olló játék**********");

            do
            {
                Console.Write("Akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }
            } while (moreGame);
            Console.ReadKey();

           
        }
    }
}
