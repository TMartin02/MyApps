using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool moreBook = true;
            string Name;
            string Answer;


            var Lista = new List<Leltár>();

            Lista.Add(new Leltár() { Name = "Maier Márk", Answer = " igen, már itt tanulok." });
            Lista.Add(new Leltár() { Name = "Maglódi Gábor", Answer = " igen, már itt tanulok." });
            Lista.Add(new Leltár() { Name = "Polgár József", Answer = "igen, már itt tanulok." });



            Console.WriteLine("******************************************");
            Console.WriteLine("********Köszöntelek az oldalamon:*********");
            Console.WriteLine("*Ird be a neved és azt jösz-e a szondiba:*");
            Console.WriteLine("******************************************");

            do
            {
                Console.WriteLine("*********************************************************************");
                Console.WriteLine("******Válasz a u,új jegyzet/ t,törlés/ l,lista/k,kilépés  Közül******");
                Console.WriteLine("*********************************************************************");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'u':
                        Console.Write("Kérem adja meg a teljes nevét:");
                        Name = Console.ReadLine();
                        Console.Write("Kérem a válaszát ha igen nyomj egy i betűt ha nem akkor n betűt.- és ha nem miét?:");
                        Answer = Console.ReadLine();
                        Lista.Add(new Leltár { Name = Name, Answer = Answer });
                        break;
                    case 'k':
                        moreBook = false;
                        break;

                    case 't':
                        Console.Write("Kérem a Leltár címét:");
                        Name = Console.ReadLine();

                        Lista.Remove(Lista.Find(x => x.Name.Contains(Name)));
                        break;
                    case 'l':
                        Console.WriteLine("Leltártár tartalom:");

                        foreach (Leltár leltár in Lista)
                        {
                            Console.WriteLine("->" + leltár.Name + " " + leltár.Answer);
                        }
                        break;
                }

            } while (moreBook);

            //Console.WriteLine("\nFind: Könyv címe tartalmaz \"Oroszlánkölykök\": {0}",Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);

        }
    }
}
