using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat("Cirmi");
            
            myCat.Sleep();
            myCat.Hunt();
            myCat.Sound();
            myCat.Born(4);
            myCat.Child();


            Dog myDog = new Dog("Buksi");

            myDog.Sleep();
            myDog.Hunt();
            myDog.Sound();
            myDog.Born(4);
            myDog.Child();
            Console.ReadKey();

            
        }
    }
}
