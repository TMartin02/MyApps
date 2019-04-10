using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tipuskonverzio
{
    class Program
    {
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

            Console.ReadKey();

        }
    }
}
