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
            int v = 0;
            string s;
            Exercise ex = new Exercise("Tomek Martin");



            Console.WriteLine(ex.Name);
            ex.printName();
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
                v--;

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
                    Console.WriteLine("Switch:" + v);
                    break;
                case 3:
                    Console.WriteLine("Switch:" + v);
                    break;

            }
            s = Console.ReadLine();
            Console.WriteLine("Ez egy szöveg:");
            ///Egy billentyű leütés
            ///Console.ReadKey(true).KeyChar
            ///integerré konvertálni a console számot(string)
            ///int.Parse(Console.ReadKey())
            ///
            int[] szamok = new int[5];
            string[] szovegek = new string[10];

            int[] iNums = new int[]{k1, 2, 3, 4, 5, 6};
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

            bool moreBook = true;
            string Name;
            string Author;
            int Page;

            Console.WriteLine("**************************************************************************************************");
            Console.WriteLine("*************************üdv a könyvtár rendszeremben*********************************************");
            Console.WriteLine("**************************************************************************************************");

            do
            {



                Console.WriteLine("**************************************************************************************************");
                Console.WriteLine("Lehetőség [u]:új könyv  [l]:listázás [t]:könyv törlése [k]:kilépés");
                Console.WriteLine("**************************************************************************************************");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'u':
                        Console.Write("Kérem a könyv címét:");
                        Name = Console.ReadLine();
                        Console.Write("Kérem a könyv szerzőjét:");
                        Author = Console.ReadLine();
                        Console.Write("Kérem a lapszámot:");
                        Page = int.Parse(Console.ReadLine());
                        Lista.Add(new Book { Name = Name, Author = Author, Page = Page });
                        break;
                    case 'k':
                        moreBook = false;
                        break;
                    case 't':
                        Console.Write("Kérem a könyv címét:");
                        Name = Console.ReadLine();
                        Lista.Remove(Lista.Find(x => x.Name.Contains(Name)));
                        break;
                    case '1':
                        Console.WriteLine("Könyvtár tartalma:");
                        foreach (Book book in Lista)
                        {
                            Console.WriteLine("->" + book.Name + " " + book.Author + " " + book.Page);
                        }
                        break;

                }


                Console.ReadKey();


            } while (moreBook);
        }
    }
}
