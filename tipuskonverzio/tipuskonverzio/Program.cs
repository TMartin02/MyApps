using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipuskonverzio
{
    class Program
    {
        private static int iPrev;

        static void Main(string[] args)
        {
            int x = 10;

            if (x is int)
            {
                Console.WriteLine("x típusa int");
            } 



                object a = "123";
            object b = "Hello";
            object c = 10;
            
            string aa = a as string;
            Console.WriteLine(aa == null ? "NULL" : aa); // 123 

            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb); // Hello 

            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc); // NULL 
            Console.WriteLine(x == 5 ? "x ==5 " : "x != 5");

            for (char ch = 'a'; ch <= 'z'; ch++)
            {
                Console.WriteLine(ch + "->" +(int)ch+ ' ');
            }

            int[] iTomb = new int[10];
            Random r = new Random();
            for (int i = 0; i < iTomb.Length; i++)
            {
                //iTomb[i] = r.next();
                Console.Write("Kérem a {0}. számot:", i);
                try
                {
                    iTomb[i] = int.Parse(Console.ReadLine());
                    iPrev = i;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Hiba." + e.Message);
                    i=iPrev;
                }
                                                        

            }
            for (int i = 0; i < iTomb.Length; i++)
            {
                Console.Write(iTomb[i] + " ");
            }

            int[] iArr = new int[] { 1, 2, 3, 4 };
            string[] sArr = new string[] { "banán,mangó,alma,körte" };

            Array.Sort(sArr);
            for (int i = 0; i < sArr.Length; i++)
            {
                Console.Write(sArr[i] + " ");
            }

            //több dimenziós tömb
            int[,] matrix = new int[,]
            {
                {12, 23, 2},
                {13, 67, 52},  
                {45, 55, 1}
            };
            Console.ReadKey();

        }
    }
}
