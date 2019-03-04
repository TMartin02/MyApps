using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruits = new List<Fruit>();
                
            string neve;
            string helye;
            int menyiseg;
            int gyumolcsszam;
            int osszmeny = 0;

            Console.Write("Kérem a gümölcsök számát:");
            gyumolcsszam = int.Parse(Console.ReadLine());
            for(int i = 0; i < gyumolcsszam; i++)
            {
                Console.Write("Kérem a (z) {0}. gyümölcs nevét:", i + 1);
                neve = Console.ReadLine();

                Console.Write("Kérem a (z) {0}. gyümölcs helyét:", i + 1);
                helye = Console.ReadLine();

                Console.Write("Kérem a (z) {0}. gyümölcs menyiségét:", i + 1);
                menyiseg = int.Parse (Console.ReadLine());

                osszmeny += menyiseg;

                fruits.Add(new Fruit(neve, helye, menyiseg));
               

            }
            Console.WriteLine("Gyümölcs összes mennyisége:" + osszmeny);

            Console.ReadKey();
       
        }
    }
}
