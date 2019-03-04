using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Fruit
    {
       public string neve;
       public string helye;
       public  int menyiseg;


       public Fruit(string Neve, string helye, int menyiseg)
        {
            neve = neve;
            helye = helye;
            menyiseg = menyiseg;
            Console.WriteLine("DEBUG: Fruit() konstruktor meghívás");

        }
    }
}
