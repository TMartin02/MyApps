using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise ex = new Exercise("Tomek Martin");

            

            Console.WriteLine(ex.Name);
            ex.PrintName();
            Console.WriteLine(ex.getName());
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Ciklus:<változó hivatkozás I.>" + i);
                Console.WriteLine("Ciklus:<változó hivatkozás II.> {0}");

            }

            v = 2;
            while (v > 0)
            {
                Console.WriteLine("while ciklus");
                v--;
            }
            v = 2;
            do
            {
                Console.WriteLine("Do ciklus");
                var--;

            } while (v > 0);
            v = 2;
            if (v == 2)
            {
                Console.WriteLine("A 'v' értéke 2");
            }
            else if (v == 3)
            {
                Console.WriteLine("A 'v' értéke 3");

            }
            else
            {
                Console.WriteLine("V nem 2 és nem 3, hanem" + v);
            }
            v = 6;
            switch (v)
            {
                case 0:
                    Console.WriteLine("Switch" + v);
                    break;
                    case 5
            }
            s = Console.ReadLine();
            Console.WriteLine("Beolvasás konzolról:" + s);
            

            Console.ReadKey();

            
        }
    }
}
