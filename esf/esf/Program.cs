using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        public static string Name { get; private set; }
        public static string Author { get; private set; }
        public static int Page { get; private set; }

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
                   
            }
            s = Console.ReadKey();
            Console.WriteLine("Ez egy szöveg:");
            ///Egy billentyű leütés
            ///Console.ReadKey(true).KeyChar
            ///integerré konvertálni a console számot(string)
            ///int.Parse(Console.ReadKey())
            ///
            int[] szamok = new int[5];
            string[] szovegek = new string[10];

            int[] iNums = new int[] (1,2,3,4,5,6);
            string[] sFruit = new string[] { "Alma", "Körte", "Eper", "Banán" };
            Console.WriteLine("iNums első eleme {0} sFruit első eleme{1}:", iNums[0], sFruit[0]);
            Console.WriteLine("iNums első eleme:" + iNums[0] + "sFruit első eleme:" + sFruit[0]);

            var Lista = new List<Book>();

            Lista.Add(new Book() { Name = "Oroszlánkölyök", Author = "Irwvin Shaw", Page = 100 });
            Lista.Add(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
            Lista.Add(new Book() { Name = "Egri csillagok", Author = "Gárdonyi Géza", Page = 1200 });

            
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            Lista.Remove(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
            Console.WriteLine("**************************************************************************************");
            foreach (Book book in Lista)
            {
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }

            Lista.Remove(Lista.Find(x => x.Name.Contains("Oroszlánkölyök")));

            Console.ReadKey();

            
        }
    }
}
