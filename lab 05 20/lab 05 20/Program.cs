using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_05_20
{
    class Program
    {
        static void Main(string[] args)
        {
         



            int[] szamok = new int[30];
            Random rnd = new Random();
            int min = 1, max = 100, i, j, k, m, n;
            bool b = true;
            for (i = 0; i < 30; i++)
            {
                do
                {
                    j = i - 1;
                    k = rnd.Next(min, max);
                    while (j > -1)
                    {
                        if (k == szamok[j])
                        {
                            k = 0;
                            j = 0;
                        }
                        j--;
                    }
                    {
                        szamok[i] = k;
                        b = true;
                        if (k != 2)
                        {
                            if (k < 2 || (k % 2) == 0) b = false;
                            else
                            {
                                m = 3;
                                n = (int)Math.Sqrt(k);
                                while (m <= n && b)
                                {
                                    if ((k % m) == 0) b = false;
                                    m += 2;
                                }
                            }
                        }
                    }
                } while (k == 0);
                Console.WriteLine(k + ":    " + (b ? "Prímszám." : "Nem Prímszám."));
            }
            Console.ReadLine();


            Console.ReadKey();

          
        }
    }
}
